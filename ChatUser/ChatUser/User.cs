using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ChatUser
{
    
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        public string Address { get; set; }
        public TcpClient Tcp { get; set; }
        public List<User> Friends;
        public List<Chat> Chats;


        //public User(TcpClient tcpClient)
        //{

        //}
    }
}
