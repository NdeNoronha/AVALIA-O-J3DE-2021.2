using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace NOME3D_NORONHA_
{
    public class Camera
    {
        Matrix view, projection;
        Vector3 position, target, up;

        public Camera()
        {
            this.position = new Vector3(10, 10, 50); ;
            this.target = Vector3.Zero;
            this.up = Vector3.Up;

            SetupView(this.position, this.target, this.up);
            SetupProjection();
        }

        public void SetupView(Vector3 p, Vector3 t, Vector3 u)
        {
            this.view = Matrix.CreateLookAt(p, t, u);
        }

        public void SetupProjection()
        {
            Screen screen = Screen.GetInstance();
            this.projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.PiOver4, screen.GetWidth() / (float)screen.GetHeight(), 0.1f, 1000);
        }

        public Matrix GetView()
        {
            return this.view;
        }

        public Matrix GetProjection()
        {
            return this.projection;
        }
    }
}
