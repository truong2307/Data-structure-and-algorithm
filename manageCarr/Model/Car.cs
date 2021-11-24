using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    // Tính trừu tượng là khả năng mà chương trình bỏ qua hoặc không chú ý đến
    // một số khía cạnh của thông tin mà nó đang trực tiếp làm việc,
    // nghĩa là nó có khả năng tập trung vào những cái cốt lõi cần thiết

    //  Data abstraction: trừu tượng hóa dữ liệu là sự tách biệt rõ ràng giữa giao diện bên ngoài của các đối tượng
    // và việc xử lý và thao tác dữ liệu bên trong
    // Giống:- abtract class và interface : không thể khởi tạo 1 đối tượng bên trong được,
    // khai báo các method nhưng k thực thi, được thực thi các method từ các lớp kế thừa, có thể kế thừa từ nhiều interface
    // khác nhau: interface k cho phép khai báo field(biến toàn cục), các method trong abstract class có thể có thân hàm còn interface thì k
    // interface k có constuctor
    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicensePlates { get; set; }

        public Car()
        {

        }

        
        // Tính đóng gói việc kết hợp một bộ các data liên quan đến nhau cùng với một bộ các functions/methods
        //  “gói” tất cả vào trong một class.
        //Tính đóng gói cho phép che giấu thông tin và những tính chất xử lý bên trong của đối tượng.
        //Các đối tượng khác không thể tác động trực tiếp đến dữ liệu bên trong và
        //làm thay đổi trạng thái của đối tượng mà bắt buộc phải thông qua các phương thức công khai do đối tượng đó cung cấp.

        // Private, public, protected chúng dùng để giới hạn hoặc quy định phạm vi truy cập của một phương thức trong lớp
        // Private: phương thức khai báo private chỉ sử dụng trong nội bộ class đó
        // Public: phương thức có khai báo public có thể được truy cập ở bất cứ lớp nào khác.
        // Protected: phương thức có khai báo protected chỉ có thể được truy cập thông qua Tính kế thừa.

        // tính trừu tượng 
        public abstract void Input();
        public abstract void Output();
    }
}
