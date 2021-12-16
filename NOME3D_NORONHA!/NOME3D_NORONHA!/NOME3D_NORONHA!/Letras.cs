using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace NOME3D_NORONHA_
{
    public class Letras
    {
        Peças[] peça;

        public Matrix world;

        public Letras(GraphicsDevice device)
        {
            this.peça = new Peças[]
            {
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device),
                new Peças(device)
            };
        }

        public void Update(GameTime gameTime)
        {
            peça[1].IntantiateCube(new Vector3(0, 2, 0));
            peça[2].IntantiateCube(new Vector3(0, 4, 0));
            peça[3].IntantiateCube(new Vector3(0, 6, 0));
            peça[4].IntantiateCube(new Vector3(0, 8, 0));
            peça[5].IntantiateRampa(0, new Vector3(2, 8, 0));
            peça[6].IntantiateCube(new Vector3(2, 6, 0));
            peça[7].IntantiateRampa(2, new Vector3(2, 4, 0));
            peça[8].IntantiateRampa(0, new Vector3(4, 6, 0));
            peça[9].IntantiateCube(new Vector3(4, 4, 0));
            peça[10].IntantiateCube(new Vector3(6, 8, 0));
            peça[11].IntantiateCube(new Vector3(6, 4, 0));
            peça[12].IntantiateCube(new Vector3(6, 6, 0));
            peça[13].IntantiateCube(new Vector3(6, 2, 0));
            peça[14].IntantiateRampa(2, new Vector3(4, 2, 0));
            peça[15].IntantiateRampa(2, new Vector3(6, 0, 0));
        }

        public void Draw(Camera camera)
        {
            for (int i = 0; i < peça.Length; i++)
            {
                this.peça[i].cube.Draw(camera);
            }
            this.peça[5].rampa.Draw(camera);
            this.peça[7].rampa.Draw(camera);
            this.peça[8].rampa.Draw(camera);
            this.peça[14].rampa.Draw(camera);
            this.peça[15].rampa.Draw(camera);
        }
    }
}
