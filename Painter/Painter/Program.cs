using System;

namespace Painter
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Paint game = new Paint())
            {
                game.Run();
            }
        }
    }
#endif
}

