using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Dealer {
    class Program {
        public static string data = null;

        public static void StartListening() {
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                Console.WriteLine("Waiting for Connection");
                while (true) {
                    Socket handler = listener.Accept();
                    data = null;

                    // An incoming connection needs to be processed.  
                    while (true) {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("!") > -1) {
                            break;
                        }
                    }
                    String card;
                    // Show the data on the console.  
                    if (data == "Let me start the Game!") {
                        Console.WriteLine("Text received : {0}", data);
                        Console.WriteLine("Okay, Granting Client access to start the game");
                        handler.Send(Encoding.ASCII.GetBytes("Start Game"));
                    }
                    if (data == "Give me a card!") {
                        Console.WriteLine("Text received : {0}", data);
                        card = cardGen();
                        Console.WriteLine("Okay, Gived out " + card);
                        handler.Send(Encoding.ASCII.GetBytes(card));
                    }
                    else {
                        Console.WriteLine("Text received : {0}", data);
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }


        //type /// 
        public static int Main(String[] args) {
            StartListening();
            return 0;
        }

        private static String cardGen() {
            Random random = new Random();
            String suit = "";
            switch (random.Next(1, 4)) {
                case 1:
                    suit = "diamonds"; //Diamond                    
                    break;
                case 2:
                    suit = "spades"; //Spade
                    break;
                case 3:
                    suit = "clubs"; //Clubs
                    break;
                case 4:
                    suit = "hearts"; //Heart
                    break;
            }
            String cardNum = "";
            switch (random.Next(1, 13)) {
                case 1:
                    cardNum = "ace"; //ACE                    
                    break;
                case 2:
                    cardNum = "2"; //2
                    break;
                case 3:
                    cardNum = "3"; //3
                    break;
                case 4:
                    cardNum = "4"; //4
                    break;
                case 5:
                    cardNum = "5"; //5
                    break;
                case 6:
                    cardNum = "6"; //6
                    break;
                case 7:
                    cardNum = "7"; //7
                    break;
                case 8:
                    cardNum = "8"; //8
                    break;
                case 9:
                    cardNum = "9"; //9
                    break;
                case 10:
                    cardNum = "10"; //10
                    break;
                case 11:
                    cardNum = "jack"; //JACK
                    break;
                case 12:
                    cardNum = "king"; //QUEEN
                    break;
                case 13:
                    cardNum = "queen"; //KING
                    break;
            }
            return cardNum + "_of_" + suit;
        }
    }
}