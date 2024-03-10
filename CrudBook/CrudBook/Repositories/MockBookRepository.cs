using CrudBook.Models;
namespace CrudBook.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        private readonly List<Book> _bookRepository;

        public MockBookRepository()
        {
            _bookRepository = new List<Book>()
            {
                new Book() { Id = 1, Author = "Mori Eto",Name="ColorFul" ,Description= "Có một người phạm tội nặng, chết đi không được luân hồi. " +
                "Nhưng trong lúc linh hồn người này đang mất trí nhớ và trôi nổi vô định về một nơi tối tăm xứng đáng với cậu ta," +
                " thì một thiên sứ cánh trắng xuất hiện, giơ tay chặn lại, thông báo rằng cậu vừa trúng phiên xổ số may mắn của thiên đình, " +
                "nhận được cơ hội tu hành kiêm tái thử thách. Theo đó, hồn cậu sẽ quay về trần gian, nhập vào xác một người vừa tự sát, " +
                "ở trọ nhà người ta, nếm trải nhân tình thế thái và xử lý đống hỗn độn mà họ để lại. Mức độ hỗn độn tương đương với mức độ tội " +
                "lỗi cậu phạm phải trong kiếp trước. Nếu việc tu hành diễn ra thuận lợi, ký ức kiếp trước sẽ dần dần quay về. Giây phút nhớ được tội lỗi mình đã gây ra cũng là lúc kết thúc quá trình ở trọ.\r\nLinh hồn cậu sẽ rời khỏi thân xác đi mượn và quay lên thiên giới, thuận lợi đặt chân vào vòng luân hồi, đầu thai sang kiếp khác. " +
                "Colorful men theo những bất an bình thường mà ai cũng có thể gặp phải trong cuộc sống, nhưng một số người lại thấy chúng quá dị thường, quá kinh khủng," +
                " dẫn đến khổ tâm dằn vặt và rồi không thể vượt được qua. Để giải phóng những bình thường ấy, Colorful trình chiếu một giải pháp đặc biệt khác thường. Cuộc đời có muôn vàn nghiệm đúng, người ta tùy ý sống theo cách mình thích, nhưng một khi đã rút lui khỏi nó, thì chẳng còn nghiệm nào cho ta lựa chọn cả."
                , Price = 67, Title = "Đời người chỉ là một chuyến ở trọ dài hạn", Image = "/images/colorful.jpg"},
                new Book() { Id = 2, Author = "Seimaru Amagi" ,Name ="Kindaichi Short File 4" ,Description ="Lời yêu cầu bảo vệ bức danh họa được gửi đến Kindaichi Hajime." +
                " Kẻ nhắm đến bức danh họa “Ngôi nhà trong ánh bình minh” chính là siêu trộm hào hoa!!\r\nSiêu trộm hào hoa đã cảnh báo sẽ hành động " +
                "“Khi bình minh thực sự thức dậ”, liệu Kindaichi có bảo vệ được bức danh họa? Trận đấu cân não đánh cược bằng niềm kiêu hãnh của thám tử và siêu trộm sẽ được mở màn!!"
                , Price = 49, Title = "Thám Tử Kindaichi Short File 04 Lời Thách Thức Từ Siêu Trộm Hào Hoa",Image ="/images/Kindaichi-short4.jpg"},
                new Book() { Id = 3, Author = "Seimaru Amagi", Name="Kindaichi Short File 5",Description = "Kẻ mở miệng xen vào trận đấu sẽ bị cắt đầu đặt lên trên “Huyết Lưu”." +
                " Cái đầu người được tìm thấy trên mặt bàn cờ vây lật ngược theo như giai thoại lưu truyền trong giới cờ vây. " +
                "(“Án mạng trong phòng Huyết Lưu”)\r\nLễ hội văn hóa trường đang diễn ra vui nhộn thì lại xảy ra vụ án mạng tại tiệm cafe hầu gái của Câu lạc bộ Nhiếp ảnh. " +
                "Liệu Kindaichi có giải đáp được bí ẩn về thi thể kỳ quái trong bộ đồ hầu gái không? (“Án mạng tại lễ hội trường Fudo”)\r\nVụ án mạng xảy ra trên tàu. Hung thủ " +
                "trở thành nạn nhân trà trộn vào buổi tiệc của idol nổi tiếng Hayami Reika! Kindaichi và thanh tra Kenmochi cũng có mặt tại đó (“Hayami Reika và vị khách không mời”)."
                , Price = 49, Title = "Thám Tử Kindaichi Short File 05 Án Mạng Trong Phòng Huyết Lưu", Image = "/images/Kindaichi-short5.jpg"},
                new Book() { Id = 4, Author = "Masaki Kishimoto", Name="Naruto" , Description = "Chuyện xảy ra ở làng Lá với nhân vật chính là Naruto, " +
                "học sinh trường đào tạo Ninja, chuyên đi quấy rối khắp làng!!\r\n\r\nNaruto có một ước mơ to lớn là đạt được danh hiệu Hokage" +
                " - Một vị trí dành cho Ninja ưu tú nhất - Và vượt qua các Ninja tiền nhiệm.\r\n\r\nTuy nhiên, bí mật về thân thế của Naruto là…!?"
                , Price = 25, Title = "Naruto Tập 1: Uzumaki Naruto (Tái Bản)", Image = "/images/Uzumaki-naruto.jpg" },
                new Book() { Id = 5, Author = "Masashi Kishimoto Takashi Yano ",Name = "Itachi Chân Truyền", Description = "Để gia nhập Anbu, Itachi đã đồng hành với người bạn thân Shisui, cả hai đương đầu với nhiệm vụ ám sát gián điệp của làng. Mâu thuẫn giữa tộc Uchiha và làng Lá ngày càng gay gắt, bằng hữu chí cốt bị sát hại... Ôm nỗi tuyệt vọng với làng, với gia tộc," +
                " cùng đôi mắt vừa khai nhãn và lòng quyết đoán, Itachi đã dấn thân vào đêm thảm kịch.\r\n\r\nNiềm hi vọng gửi gắm cho em trai cùng ước mơ...\r\n\r\nToàn bộ sự thật tàn khốc đều hiện diện ở chốn này."
                , Price = 66, Title = "Tiểu Thuyết Naruto - Itachi Chân Truyền: Ám Dạ Thiên", Image = "/images/Itachi.jpg" },
                new Book() { Id = 6, Author = "Sir Arthur Conan Doyle", Name = "Sherlock Holmes", Description = "Arthur Conan Doyle sinh năm 1859 tại Edinburgh, Scotland. Ông nghiên cứu y khoa ở trường Đại học Edinburgh và định cư tại London," +
                " song việc hành nghề không mấy thành đạt tạo cho ông nhiều thời gian rảnh rỗi. Đó cũng chính là thời điếm ông bắt đầu viết những câu chuyện nổi tiếng về Sherlock Holmes. Tác phẩm thành công đầu tiên là “Sự nghiên cứu màu đỏ”," +
                " ra mắt công chúng tại Triển lãm sách thường niên tại Beeton năm 1887. Sau khi phát hành cuốn “Bốn vết tích” vào năm 1890, Conan Doyle rời bỏ nghề y để toàn tâm toàn ý với công việc sáng tác văn học. Chính hình ảnh của thám tử" +
                " siêu việt Sherlock Holmes mang lại tiếng tăm lừng lẫy cho nhà văn. Khi Doyle đã nhàm chán Holmes và “cho” Holmes chết bằng “Cú đấm cuối cùng” được xuất bản năm 1893, thi công chúng đã buộc ông phải tái sinh Sherlock Holmes một" +
                " cách tài tình.\r\n\r\nArthur Conan Doyle có một cuộc sống nhiều màu sắc và ưa mạo hiểm. Ông là một sử gia, một người săn cá voi, một vận động viên, một phóng viên báo chi thời chiến và một là người theo thuyết duy linh. Đích" +
                " thân ông đã bênh vực cho hai trường họp bất công, vận dụng tác phẩm trinh thám của chính ông để chứng minh sự vô tội của những người đàn ông bị kết án. Năm 1902 Conan Doyle đã được phong tước hầu vì những cống hiến của ông tại" +
                " một bệnh viện ở Nam Phi trong cuộc chiến tranh của người Phi gốc Hà Lan. Ổng mất năm 1930."
                , Price = 110, Title = "Sherlock Holmes Toàn Tập Tập 1", Image = "/images/Sherlock_home.jpg" }
            };
        }
        public IEnumerable<Book> GetAll()
        {
            return _bookRepository;
        }

        public Book GetbyId(int id)
        {
            return _bookRepository.FirstOrDefault(p => p.Id == id) ;
        }
        public void Add(Book book)
        {
            book.Id = _bookRepository.Max(x => x.Id);
            _bookRepository.Add(book);
        }
        public void Update(Book book)
        {
            var index = _bookRepository.FindIndex(p => p.Id == book.Id);
            if (index != -1)
            {   
                if(book.Image == null)
                {
                    book.Image = _bookRepository[index].Image;
                }
                _bookRepository[index] = book;
            }
        }

        public void Delete(int id) 
        {
            var item = _bookRepository.FirstOrDefault(p => p.Id == id);
            if (item != null)
            {
                _bookRepository.Remove(item);
            }
        }
    }
}
