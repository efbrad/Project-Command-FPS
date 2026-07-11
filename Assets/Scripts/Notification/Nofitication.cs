using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Notification
    {
        public String Name { get; set; }
        public Object Object { get; set; }
        public Object Object2 { get; set; }
        public Dictionary<String, Object> UserInfo { get; set; }
        public int value;
        public Notification() : this("NotificationName")
        {
        }

        public Notification(String name) : this(name, null)
        {
        }

        public Notification(String name, Object obj) : this(name, obj, null)
        {
        }

        public Notification(String name, Object obj, Dictionary<String, Object> userInfo)
        {
            this.Name = name;
            this.Object = obj;
            this.UserInfo = userInfo;
        }
        public Notification(String name, Object obj, int value)
        {
            this.Name = name;
            this.Object = obj;
            this.value = value;
        }
        public Notification(String name, Object obj, Object obj2)
        {
            this.Name = name;
            this.Object = obj;
            this.Object2 = obj2;
        }
    }
