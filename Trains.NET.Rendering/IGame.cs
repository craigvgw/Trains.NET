﻿using SkiaSharp;

namespace Trains.NET.Rendering
{
    public interface IGame
    {
        Tool CurrentTool { get; set; }

        void OnMouseDown(int x, int y, bool isRightMouseButton);
        void Render(SKCanvas canvas);
        void SetSize(int width, int height);
    }
}
