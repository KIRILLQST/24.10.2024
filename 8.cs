﻿using System;
using System.Collections.Generic;

namespace OrderSystem
{
    public class NotificationSystem
    {
        private Queue<string> _notifications;

        public NotificationSystem()
        {
            _notifications = new Queue<string>();
        }

        public void AddNotification(string notification)
        {
            _notifications.Enqueue(notification);
        }

        public string GetNextNotification()
        {
            if (_notifications.Count == 0)
            {
                return null;
            }
            return _notifications.Dequeue();
        }
    }
}