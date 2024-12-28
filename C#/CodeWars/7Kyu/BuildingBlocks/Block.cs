using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7Kyu.BuildingBlocks
{
    /*
     * 
     * The constructor should take an array as an argument, 
     * this will contain 3 integers of the form [width, length, height] from which the Block should be created.
     */
    public class Block
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }

        public Block() { }

        public Block(int [] block)
        {
            if (block == null || block.Length != 3)
            {
                throw new ArgumentException("Input array must contain exactly 3 elements: [Width, Length, Height].");
            }

            Width = block[0];
            Length = block[1];
            Height = block[2];
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight() { return Height; }

        public int GetLength() {  return Length; }

        public int GetVolume() {  return Width * Height * Length; }

        public int GetSurfaceArea()
        {
            return 2 * (Width * Length + Width * Height + Length * Height);
        }
    }
}
