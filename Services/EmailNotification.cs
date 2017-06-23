using System;

namespace my_web.Services {
    public class EmailNotification : INotification {
        public void Notify(string message) {
            Console.WriteLine("Notified: " + message);
        }
    }
}