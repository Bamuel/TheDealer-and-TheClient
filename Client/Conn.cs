using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Task4 {
    class Conn {
        public string TestConc(string ip, string message) {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try {
                IPEndPoint remoteEP = null;

                if (ip == "localhost") {
                    IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                    IPAddress ipAddress = ipHostInfo.AddressList[0];
                    remoteEP = new IPEndPoint(ipAddress, 11000);
                }
                else {
                    remoteEP = new IPEndPoint(long.Parse(ip), 11000);
                }
                // Create a TCP/IP  socket.  
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(message+"!");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);
                    String ECHOEDTEXT = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    

                    //Encoding.ASCII.GetString(bytes, 0, bytesRec) - recieved from Dealer

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    return ECHOEDTEXT;

                }
                catch (ArgumentNullException ane) {
                    return String.Format("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se) {
                    return String.Format("SocketException : {0}", se.ToString());
                }
                catch (Exception e) {
                    return String.Format("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e) {
                return (e.ToString());
            }
        }
    }
}
