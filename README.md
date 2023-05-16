# TinhNgaySinhNhat
Chúng ta nhập ngày sinh dưới định dạng "dd/MM/yyyy" từ bàn phím bằng cách sử dụng Console.ReadLine() và DateTime.Parse() để chuyển đổi chuỗi nhập vào thành đối tượng DateTime đại diện cho ngày sinh.

Sau đó, chúng ta lấy ngày hiện tại bằng DateTime.Now và tạo một đối tượng DateTime mới cho ngày sinh nhật trong năm hiện tại với cùng tháng và ngày như ngày sinh và năm là năm hiện tại. Nếu ngày sinh nhật đã qua trong năm nay, chúng ta thêm 1 năm vào ngày sinh nhật để lấy ngày sinh nhật trong năm tiếp theo.

Tiếp theo, chúng ta tính toán khoảng thời gian giữa ngày sinh nhật và ngày hiện tại bằng cách trừ ngaySinhNhatTiepTheo cho ngayHienTai. Kết quả là một đối tượng TimeSpan đại diện cho khoảng thời gian giữa hai ngày. Chúng ta lấy thuộc tính Days từ đối tượng TimeSpan để lấy số ngày còn lại.

Cuối cùng, chúng ta in ra số ngày còn lại đến sinh nhật sử dụng Console.WriteLine()
