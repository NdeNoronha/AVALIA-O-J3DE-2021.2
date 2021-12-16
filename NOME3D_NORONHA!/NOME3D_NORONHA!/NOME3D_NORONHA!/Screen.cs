using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NOME3D_NORONHA_
{
    public class Screen
    {
        int WIDTH, HEIGHT;
        static Screen instance;

        private Screen()
    {

    }

        public static Screen GetInstance()
        {
            if(instance == null)
            {
                instance = new Screen();
            }
            return instance;
        }

        public void SetWidth(int width)
        {
            WIDTH = width;
        }

        public int GetWidth()
        {
            return WIDTH;
        }

        public void SetHeight(int height)
        {
            HEIGHT = height;
        }

        public int GetHeight()
        {
            return HEIGHT;
        }
    }
}
