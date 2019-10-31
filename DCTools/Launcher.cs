using System;


namespace DCTools {
    class Launcher {
        [STAThread]
        static void Main(string[] args) {
            UI.App app = new UI.App();
            app.Run(new UI.MainWindow());

        }
    }
}
