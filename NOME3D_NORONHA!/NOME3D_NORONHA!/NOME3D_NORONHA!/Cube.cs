using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NOME3D_NORONHA_
{
    public class Cube
    {
        public Matrix world;
        VertexPositionColor[] verts;
        VertexBuffer buffer;
        BasicEffect effect;
        GraphicsDevice device;

        public Cube(GraphicsDevice device)
        {
            this.device = device;
            this.world = Matrix.Identity;
            this.verts = new VertexPositionColor[]
            {

                //FRENTE
                new VertexPositionColor(new Vector3(1,1,1), Color.Red),
                new VertexPositionColor(new Vector3(1,-1,1), Color.Green),
                new VertexPositionColor(new Vector3(-1,-1,1), Color.Blue),

                new VertexPositionColor(new Vector3(-1,-1,1), Color.Red),
                new VertexPositionColor(new Vector3(-1,1,1), Color.Green),
                new VertexPositionColor(new Vector3(1,1,1), Color.Blue),

                //ESQUERDA
                new VertexPositionColor(new Vector3(-1,1,1), Color.Red),
                new VertexPositionColor(new Vector3(-1,-1,1), Color.Green),
                new VertexPositionColor(new Vector3(-1,-1,-1), Color.Blue),

                new VertexPositionColor(new Vector3(-1,-1,-1), Color.Red),
                new VertexPositionColor(new Vector3(-1,1,-1), Color.Green),
                new VertexPositionColor(new Vector3(-1,1,1), Color.Blue),

                 //ATRÁS
                new VertexPositionColor(new Vector3(-1,1,-1), Color.Red),
                new VertexPositionColor(new Vector3(-1,-1,-1), Color.Green),
                new VertexPositionColor(new Vector3(1,-1,-1), Color.Blue),

                new VertexPositionColor(new Vector3(1,-1,-1), Color.Red),
                new VertexPositionColor(new Vector3(1,1,-1), Color.Green),
                new VertexPositionColor(new Vector3(-1,1,-1), Color.Blue),

                //DIREITA
                new VertexPositionColor(new Vector3(1,1,-1), Color.Red),
                new VertexPositionColor(new Vector3(1,-1,-1), Color.Green),
                new VertexPositionColor(new Vector3(1,-1,1), Color.Blue),

                new VertexPositionColor(new Vector3(1,-1,1), Color.Red),
                new VertexPositionColor(new Vector3(1,1,1), Color.Green),
                new VertexPositionColor(new Vector3(1,1,-1), Color.Blue),

                //BAIXO
                new VertexPositionColor(new Vector3(1,-1,1), Color.Red),
                new VertexPositionColor(new Vector3(1,-1,-1), Color.Green),
                new VertexPositionColor(new Vector3(-1,-1,-1), Color.Blue),

                new VertexPositionColor(new Vector3(-1,-1,-1), Color.Red),
                new VertexPositionColor(new Vector3(-1,-1,1), Color.Green),
                new VertexPositionColor(new Vector3(1,-1,1), Color.Blue),

                //CIMA
                new VertexPositionColor(new Vector3(1,1,-1), Color.Red),
                new VertexPositionColor(new Vector3(1,1,1), Color.Green),
                new VertexPositionColor(new Vector3(-1,1,1), Color.Blue),

                new VertexPositionColor(new Vector3(-1,1,1), Color.Red),
                new VertexPositionColor(new Vector3(-1,1,-1), Color.Green),
                new VertexPositionColor(new Vector3(1,1,-1), Color.Blue),
            };
            this.buffer = new VertexBuffer(this.device, typeof(VertexPositionColor), this.verts.Length, BufferUsage.None);
            this.buffer.SetData<VertexPositionColor>(this.verts);
            this.effect = new BasicEffect(this.device);
        }
        public void Update(GameTime gameTime)
        {
            //this.world *= Matrix.CreateRotationX(0.01f);
        }

        public void Rotation(int i, float a)
        {
            switch (i)
            {
                case 0:
                    this.world = Matrix.CreateRotationX(a);
                    break;
                case 1:
                    this.world = Matrix.CreateRotationY(a);
                    break;
                case 2:
                    this.world = Matrix.CreateRotationZ(a);
                    break;
            }
        }

        public void Translation(Vector3 p)
        {
            this.world = Matrix.CreateTranslation(p);
        }

        public void Draw(Camera camera)
        {
            this.device.SetVertexBuffer(this.buffer);
            this.effect.World = this.world;
            this.effect.View = camera.GetView();
            this.effect.Projection = camera.GetProjection();
            this.effect.VertexColorEnabled = true;

            foreach (EffectPass pass in this.effect.CurrentTechnique.Passes)
            {
                pass.Apply();
                this.device.DrawUserPrimitives<VertexPositionColor>(PrimitiveType.TriangleList, this.verts, 0, this.verts.Length/3);
            }
        }
    }
}
