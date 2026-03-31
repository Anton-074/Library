namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formlogin = new FormLogin())
                {
                    if (formlogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formBooks = new FormBooks(
                            formlogin.CurrentUser,
                            formlogin.IsGuest))
                        {
                            if (formBooks.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;

                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}