using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    // Tính kế thừa cho phép xây dựng một lớp mới,
    // kế thừa và tái sử dụng các thuộc tính,
    // phương thức dựa trên lớp lớp Cha đã có trước đó. 

    // các loại kế thừa: đơn kế thừa là 1 class chỉ được kế thừa tư một lớp duy nhất, nghĩa là 1 lớp con chỉ có 1 lớp cha
    // kế thừa đa cấp: là sẽ có một lớp kế thừa được tạo ra từ một lớp kế thừa khác.
    // kế thừa phân cấp: sẽ có nhiều lớp con được kế thừa từ một lớp cha duy nhất.

    public class Truck : Car
    {
        public int Weight { get; set; }

        public Truck() 
        {

        }

        //tính đa hình một biến, một hàm hoặc một phương thức có thể tồn tại ở nhiều dạng khác nhau.
        //Tức là nhiều hàm hoặc phương thức có thể cùng một tên nhưng chức năng của chúng lại khác nhau.

        // overriding được sử dụng trong trường hợp lớp con kế thừa từ lớp cha và muốn định nghĩa lại 1 phương thức của lớp cha 
        // Một lớp cha thông thường có thể có nhiều lớp con kế thừa,
        // tuy nhiên phương thức ở lớp cha có thể phù hợp với lớp con này nhưng không phù hợp với lớp con khác,
        // do đó lớp con cần ghi đè lại phương thức đó cho phù hợp

        // overloading
        // overloading nạp chồng method cho phép trong cùng một class có thể có nhiều phương thức cùng
        //tên nhưng khác nhau về số lượng tham số hoặc kiểu dữ liệu tham số
        //overloading operator: Chồng toán tử tức là cho phép định nghĩa lại những phép toán đã có với các kiểu dữ liệu do mình xây dựng.

        // phân biệt override và overload: overload khác nhau về tham số và kiểu dữ liệu của tham số còn override phải giống,
        // overload xảy ra trong cùng 1 class còn override xảy ra khi 2 class có quan hệ kế thừa 
        public override void Input()
        {
            Console.WriteLine("Import Id");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Import Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Import License Plates");
            this.LicensePlates = Console.ReadLine();
            Console.WriteLine("Import Car Weight");
            this.Weight = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("License Plates: " + LicensePlates);
            Console.WriteLine("Car Weight: " + Weight);
        }
    }
}
