using System.Text;
using System.Threading.Tasks;

namespace DungeonGenerator
{
    public class Room
    {
        public string RoomType { get; private set; }
        public Cell[] Cells { get; private set; }

        public Room(string type, Cell[] cells)
        {

        }
    }
}
