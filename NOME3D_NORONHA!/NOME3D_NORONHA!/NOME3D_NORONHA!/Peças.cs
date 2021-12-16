using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace NOME3D_NORONHA_
{
    public class Peças
    {
        public Cube cube;
        public Rampa rampa;
        public Bandeira bandeira;

        public Peças(GraphicsDevice device)
        {
            this.cube = new Cube(device);
            this.rampa = new Rampa(device);
            this.bandeira = new Bandeira(device);
        }

        public void Update(GameTime gameTime)
        {

        }

        public void IntantiateRampa(int i, Vector3 p)
        {
            switch (i)
            {
                case 0:
                    this.rampa.Rotation(0, 0);
                    this.rampa.Translation(p);
                    break;
                case 1:
                    this.rampa.Rotation(2, MathHelper.Pi / 2);
                    this.rampa.Translation(p);
                    break;
                case 2:
                    this.rampa.Rotation(2, MathHelper.Pi);
                    this.rampa.Translation(p);
                    break;
                case 3:
                    this.rampa.Rotation(2, MathHelper.Pi / 2 + MathHelper.Pi);
                    this.rampa.Translation(p);
                    break;
            }
        }
        public void IntantiateBandeira(int i, Vector3 p)
        {
            switch (i)
            {
                case 0:
                    this.bandeira.Rotation(0, 0);
                    this.bandeira.Translation(p);
                    break;
                case 1:
                    this.bandeira.Rotation(2, MathHelper.Pi / 2);
                    this.bandeira.Translation(p);
                    break;
                case 2:
                    this.bandeira.Rotation(2, MathHelper.Pi);
                    this.bandeira.Translation(p);
                    break;
                case 3:
                    this.bandeira.Rotation(2, MathHelper.Pi / 2 + MathHelper.Pi);
                    this.bandeira.Translation(p);
                    break;
            }
        }
        public void IntantiateCube(Vector3 p)
        {
            this.cube.Translation(p);
        }
        public void Draw(Camera camera)
        {

        }

    }
}
