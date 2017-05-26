
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ClassLibrary1
{

    public enum PacketType
    {
        서버 = 0,
        유저
    }
    public enum PacketSendError
    {
        정상 = 0,
        에러
    }

    [Serializable]
    public class Packet
    {
        public int Length;
        public int type;
        public Packet()
        {
            this.Length = 0;
            this.type = 0;
        }
        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        public static Object Deserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 2);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }
    [Serializable]
    public class SendToServer : Packet
    {
        public int[,] gameBoard = new int[8, 14];
        public int addObstacle = 0;
        public bool isplaying = false;

        public int finalScore = 0;
    }

    [Serializable]
    public class SendToClient : Packet
    {
        public int[,] gameBoard = new int[8, 14];
        public int addObstacle = 0;
        public bool isplaying = false;


    }
}
//----------------------------------------------------------//
// 1p에서 2p의 화면을 폼에 보여줄때
// 1. 2p의 최근뿌요를 내려놓은 상태의 gameboard ->gameBoard
// 2. 2p의 콤보 (1p에 장애물을 놓기 위해) ->addObstacle
// 3. 2p의 게임이 시작인지 종료인지 ->isplaying

// SendToServer / 1p나 2p에서 서버로 보낼것
// 1. 1p나 2p의 최종 점수 (Ranking) ->finalScore
// 2. 

//-----------------------------------------------------------//


