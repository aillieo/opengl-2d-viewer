﻿using System;
using System.Net;
using System.Net.Sockets;
using GNetwork;

namespace fake_server
{

	class CommunicationManager
	{

		public CommunicationManager(Socket s)
		{
			_socket = s;
		}

		private Socket _socket;


		public bool SendMessage(int index, int type,global::ProtoBuf.IExtensible msg)
		{

			System.IO.MemoryStream stream = new System.IO.MemoryStream ();
			ProtoBuf.Serializer.Serialize(stream , msg);
			byte[] bMsg = stream.ToArray();

			int len = 4 + 4 + bMsg.Length;
			byte[] bLen = BitConverter.GetBytes(len);
			System.Array.Reverse (bLen);
            byte[] bIndex = BitConverter.GetBytes(index);
            System.Array.Reverse(bIndex);
			byte[] bType = BitConverter.GetBytes(type);
			System.Array.Reverse (bType);

			byte[] bSend = new byte[4 + len];
			Array.Copy(bLen, 0, bSend, 0, 4);
            Array.Copy(bIndex, 0, bSend, 4, 4);
			Array.Copy(bType, 0, bSend, 8, 4);
			Array.Copy(bMsg, 0, bSend, 12, len - 8);
			_socket.Send(bSend);

			return true;
		}

		public void Receive(byte[] data, int len)
		{
            int index = 0;
            byte[] bIndex = new byte[4];
            Array.Copy(data, 0, bIndex, 0, 4);
            System.Array.Reverse(bIndex);
            index = BitConverter.ToInt32(bIndex, 0);
			int type = 0;
			byte[] bType = new byte[4];
			Array.Copy(data,4,bType,0,4);
			System.Array.Reverse (bType);
			type = BitConverter.ToInt32(bType, 0);
			byte[] bRecv = new byte[len - 8];
			Array.Copy(data,8,bRecv,0,len - 8);
			System.IO.MemoryStream stream = new System.IO.MemoryStream(bRecv);
			ParseMessage(index, type, stream);
		}

		private void ParseMessage(int index, int type, System.IO.MemoryStream stream)
		{
			switch (type) {
			case MessageTypes.C2S_Login:
				{
					ProtoBuf.C2S_Login msg = ProtoBuf.Serializer.Deserialize<ProtoBuf.C2S_Login> (stream);
                    var resp = FakeMegGenerators.GenMsg(msg);
                    SendMessage(index, MessageTypes.S2C_Login, resp);
					break;
				}
			case MessageTypes.C2S_UserInit:
				{
					ProtoBuf.C2S_UserInit msg = ProtoBuf.Serializer.Deserialize<ProtoBuf.C2S_UserInit> (stream);
                    var resp = FakeMegGenerators.GenMsg(msg);
                    SendMessage(index, MessageTypes.S2C_UserInit, resp);
					break;
				}
			case MessageTypes.C2S_RoleInit:
				{
					ProtoBuf.C2S_RoleInit msg = ProtoBuf.Serializer.Deserialize<ProtoBuf.C2S_RoleInit> (stream);
                    var resp = FakeMegGenerators.GenMsg(msg);
                    SendMessage(index, MessageTypes.S2C_RoleInit, resp);
					break;
				}
			case MessageTypes.C2S_NewHero:
				{
					ProtoBuf.C2S_NewHero msg = ProtoBuf.Serializer.Deserialize<ProtoBuf.C2S_NewHero> (stream);
                    var resp = FakeMegGenerators.GenMsg(msg);
                    SendMessage(index, MessageTypes.S2C_NewHero, resp);
					break;
				}
			}

		}


	}
}