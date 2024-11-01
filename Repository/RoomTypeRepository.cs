using BussinessObject;
using DataAccessLayer;
namespace Repository
{
    internal class RoomTypeRepository : IRoomTypeRepository
    {
        public void AddRoomType(RoomType roomType) => RoomTypeDAO.Instance.AddRoomType(roomType);
      

        public void DeleteRoomType(int id) => RoomTypeDAO.Instance.DeleteRoomType(id);
       

        public List<RoomType> GetAllRoomTypes() => RoomTypeDAO.Instance.GetAllRoomTypes();

        public RoomType GetRoomTypeById(int id) => RoomTypeDAO.Instance.GetRoomTypeById(id);
 

        public void UpdateRoomType(RoomType roomType) => RoomTypeDAO.Instance.UpdateRoomType(roomType);
    }
}
