﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using Avalonia;
using Avalonia.Data;
using Avalonia.Media;
using Avalonia.Metadata;
using Avalonia.Controls;
using Avalonia.Visuals.Media.Imaging;
using SixLabors.ImageSharp;

namespace Svg.Skia.Avalonia
{
    /// <summary>
    /// An <see cref="IImage"/> that uses a <see cref="ISvg"/> for content.
    /// </summary>
    public class SvgImage : AvaloniaObject, IImage, IAffectsRender
    {
        /// <summary>
        /// Defines the <see cref="Source"/> property.
        /// </summary>
        public static readonly StyledProperty<ISvg> SourceProperty =
            AvaloniaProperty.Register<SvgImage, ISvg>(nameof(Source));

        /// <inheritdoc/>
        public event EventHandler? Invalidated;

        /// <summary>
        /// Gets or sets the <see cref="ISvg"/> content.
        /// </summary>
        [Content]
        public ISvg Source
        {
            get => GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        /// <inheritdoc/>
        public Size Size =>
            Source?.Picture != null ? new Size(Source.Picture.CullRect.Width, Source.Picture.CullRect.Height) : default;

        /// <inheritdoc/>
        void IImage.Draw(
            DrawingContext context,
            Rect sourceRect,
            Rect destRect,
            BitmapInterpolationMode bitmapInterpolationMode)
        {
            var source = Source;
            if (source == null || source.Picture == null)
            {
                return;
            }

            var bounds = source.Picture.CullRect;
            var scale = Matrix.CreateScale(
                destRect.Width / sourceRect.Width,
                destRect.Height / sourceRect.Height);
            var translate = Matrix.CreateTranslation(
                -sourceRect.X + destRect.X - bounds.Top,
                -sourceRect.Y + destRect.Y - bounds.Left);

            using (context.PushClip(destRect))
            using (context.PushPreTransform(translate * scale))
            {
                context.Custom(
                    new SvgCustomDrawOperation(
                        new Rect(0, 0, bounds.Width, bounds.Height),
                        source));
            }
        }

        /// <inheritdoc/>
        protected override void OnPropertyChanged<T>(AvaloniaProperty<T> property, Optional<T> oldValue, BindingValue<T> newValue, BindingPriority priority)
        {
            base.OnPropertyChanged(property, oldValue, newValue, priority);

            if (property == SourceProperty)
            {
                RaiseInvalidated(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Raises the <see cref="Invalidated"/> event.
        /// </summary>
        /// <param name="e">The event args.</param>
        protected void RaiseInvalidated(EventArgs e) => Invalidated?.Invoke(this, e);
    }
}
