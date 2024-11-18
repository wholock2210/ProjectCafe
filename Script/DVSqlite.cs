using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using ProjectCafe.Models;

namespace ProjectCafe.Script
{
     class DVSqlite
    {
        private readonly string dbFilepath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName,"Resources", "Database", "SQLiteCafe.db");
        private readonly CafeDbContext dbContext;
        public DVSqlite()
        {
            
            string folderPath = Path.GetDirectoryName(dbFilepath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(dbFilepath))
            {
                MessageBox.Show("chưa có data nên chương trình sẽ tự động tạo mới");
                CreateDatabase(dbFilepath);
            }
            dbContext = new CafeDbContext();
        }

        public async Task<List<Tang>> GetTangsAsync()
        {
            return await dbContext.Tangs.ToListAsync();
        }

        public async Task AddTang(Tang tang)
        {
            if(tang == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Tangs.AddAsync(tang);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm tầng {tang.Tang1} thành công");
            }catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra :{ex.Message}");
            }
        }

        public async Task RemoveTang(Tang tang)
        {
            if(tang == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Tangs.Remove(tang);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Ban>> GetBansAsync()
        {
            return await dbContext.Bans.ToListAsync();
        }

        public async Task AddBan(Ban ban)
        {
            if (ban == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Bans.AddAsync(ban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm {ban.Maban} ở tầng {ban.Tang} thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }

        public async Task Remove(Ban ban)
        {
            if (ban == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Bans.Remove(ban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Trangthaiban>> GetTrangthaibansAsync()
        {
            return await dbContext.Trangthaibans.ToListAsync();
        }

        public async Task AddTrangThaiBan(Trangthaiban trangthaiban)
        {
            if (trangthaiban == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Trangthaibans.AddAsync(trangthaiban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm {trangthaiban.Tentrangthaiban} thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }

        public async Task RemoveTrangThaiBan(Trangthaiban trangthaiban)
        {
            if (trangthaiban == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Trangthaibans.Remove(trangthaiban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Datban>> GetDatbansAsync()
        {
            return await dbContext.Datbans.ToListAsync();
        }

        public async Task AddDatBan(Datban datban)
        {
            if (datban == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Datbans.AddAsync(datban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }
        
        public async Task UpdateDatBan(Datban datban)
        {
            var upDB = await dbContext.Datbans.FirstOrDefaultAsync(d => (d.Maban == datban.Maban) && (d.Tang == datban.Tang));
            if(upDB == null)
            {
                MessageBox.Show("không tìm thấy đơn đặt bàn");
                return;
            }
            try
            {
                upDB.Thoigianvao = datban.Thoigianvao;
                upDB.Thoigianra = datban.Thoigianra;
                await dbContext.SaveChangesAsync();
                MessageBox.Show("cập nhật thành công");
            }catch(Exception ex)
            {
                MessageBox.Show("cập nhật thất bại");
            }
        }

        public async Task RemoveDatBan(Datban datban)
        {
            if (datban == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Datbans.Remove(datban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Loaimon>> GetLoaimonsAsync()
        {
            return await dbContext.Loaimons.ToListAsync();
        }

        public async Task AddLoaiMon(Loaimon loaimon)
        {
            if (loaimon == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Loaimons.AddAsync(loaimon);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"đặt bàn thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }

        public async Task RemoveLoaiMon(Loaimon loaimon)
        {
            if (loaimon == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Loaimons.Remove(loaimon);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Mon>> GetMonsAsync() => await dbContext.Mons.ToListAsync();

        public async Task AddMon(Mon mon)
        {
            if (mon == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Mons.AddAsync(mon);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"đặt bàn thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }

        public async Task RemoveMon(Mon mon)
        {
            if (mon == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Mons.Remove(mon);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Khachhang>> GetKhachhangsAsync() => await dbContext.Khachhangs.ToListAsync();

        public async Task AddKhachHang(Khachhang khachhang)
        {
            if (khachhang == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Khachhangs.AddAsync(khachhang);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }

        public async Task UpdateKhachHang(Khachhang khachhang)
        {
            var upKH = await dbContext.Khachhangs.FirstOrDefaultAsync(k => k.Makh == khachhang.Makh);
            if(upKH == null)
            {
                MessageBox.Show("Không tìm thấy");
                return;
            }
            try
            {
                upKH.Tenkh = khachhang.Tenkh;
                upKH.Sdt = khachhang.Sdt;
                upKH.Email = khachhang.Email;

                await dbContext.SaveChangesAsync();
                MessageBox.Show("sửa thành công!");
            }catch (Exception ex)
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        public async Task RemoveKhachHang(Khachhang khachhang)
        {
            if (khachhang == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Khachhangs.Remove(khachhang);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Ordertaiban>> GetOrdertaibansAsync() => await dbContext.Ordertaibans.ToListAsync();

        public async Task AddOrderTaiBan(Ordertaiban ordertaiban)
        {
            if (ordertaiban == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Ordertaibans.AddAsync(ordertaiban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }
        
        public async Task RemoveOrderTaiBan(Ordertaiban ordertaiban)
        {
            if (ordertaiban == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Ordertaibans.Remove(ordertaiban);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Dsmonordertb>> GetDsmonordertbsAsync() => await dbContext.Dsmonordertbs.ToListAsync();

        public async Task AddDsmonOrderTB(Dsmonordertb ordertb)
        {
            if (ordertb == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Dsmonordertbs.AddAsync(ordertb);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }

        public async Task UpdateDsMonOrderTB(Dsmonordertb ordertb)
        {
            var upDSTB = await dbContext.Dsmonordertbs.FirstOrDefaultAsync(ds => (ds.Maordertb == ordertb.Maordertb) &&
                                                                                 (ds.Makh == ordertb.Makh) &&
                                                                                 (ds.Maban ==  ordertb.Maban) &&
                                                                                 (ds.Tang == ordertb.Tang) &&
                                                                                 (ds.Mamon == ordertb.Mamon));
            if(upDSTB == null)
            {
                MessageBox.Show("không tìm thấy");
                return;
            }
            try
            {
                upDSTB.Soluong = ordertb.Soluong;
                upDSTB.Size = ordertb.Size;

                await dbContext.SaveChangesAsync();
                MessageBox.Show("sửa thành công");
            }catch (Exception ex)
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        public async Task RemoveDsOrderTB(Dsmonordertb ordertb)
        {
            if (ordertb == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Dsmonordertbs.Remove(ordertb);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Ordertaiquay>> GetOrdertaiquaysAsync() => await dbContext.Ordertaiquays.ToListAsync();

        public async Task AddOrderTQ(Ordertaiquay ordertaiquay)
        {
            if (ordertaiquay == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Ordertaiquays.AddAsync(ordertaiquay);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }
        public async Task UpdateOrderTQ(Ordertaiquay ordertaiquay)
        {
            var upTQ = await dbContext.Ordertaiquays.FirstOrDefaultAsync(tq => (tq.Maordertq == ordertaiquay.Maordertq) &&
                                                                                (tq.Makh == ordertaiquay.Makh));
            if(upTQ == null)
            {
                MessageBox.Show("không tìm thấy");
                return;
            }
            try
            {
                upTQ.Ghichu = ordertaiquay.Ghichu;
                upTQ.Maban = ordertaiquay.Maban;
                upTQ.Tang = ordertaiquay.Tang;

                await dbContext.SaveChangesAsync();
                MessageBox.Show("sửa thành công");
            }catch (Exception ex)
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        public async Task RemoveOrderTQ(Ordertaiquay ordertaiquay)
        {
            if (ordertaiquay == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Ordertaiquays.Remove(ordertaiquay);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }

        public async Task<List<Dsmonordertq>> GetDsmonordertqsAsync() => await dbContext.Dsmonordertqs.ToListAsync();

        public async Task AddDsMonOrderTQ(Dsmonordertq dsmonordertq)
        {
            if (dsmonordertq == null)
            {
                MessageBox.Show("dữ liệu không hợp lệ");
                return;
            }
            try
            {
                await dbContext.Dsmonordertqs.AddAsync(dsmonordertq);
                await dbContext.SaveChangesAsync();
                MessageBox.Show($"thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"có lỗi xảy ra : {ex.Message}");
            }
        }
        public async Task UpdateDSMonOrderTQ(Dsmonordertq dsmonordertq)
        {
            var upTQ = await dbContext.Dsmonordertqs.FirstOrDefaultAsync(tq => (tq.Mamon == dsmonordertq.Mamon) &&
                                                                                (tq.Makh == dsmonordertq.Makh) &&
                                                                                (tq.Maordertq == dsmonordertq.Maordertq));
            if( upTQ == null)
            {
                MessageBox.Show("không tìm thấy");
                return;
            }
            try
            {
                upTQ.Soluong = dsmonordertq.Soluong;
                upTQ.Size = dsmonordertq.Size;

                await dbContext.SaveChangesAsync();
                MessageBox.Show("sửa thành công");
            }catch (Exception ex)
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        public async Task RemoveDsMonOrderTQ(Dsmonordertq dsmonordertq)
        {
            if (dsmonordertq == null)
            {
                MessageBox.Show("xoá thất bại");
            }
            else
            {
                dbContext.Dsmonordertqs.Remove(dsmonordertq);
                await dbContext.SaveChangesAsync();
                MessageBox.Show("Xoá Thành Công");
            }
        }


        private void CreateDatabase(string Path)
        {
            using (var connection = new SqliteConnection($"Data Source={Path}"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "PRAGMA foreign_keys = ON;";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS LOAIMON(
                                        MALOAIMON INTEGER PRIMARY KEY,
                                        TENLOAIMON TEXT NOT NULL)";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS MON(
                                        MAMON INTEGER PRIMARY KEY,
                                        TENMON TEXT NOT NULL,
                                        GIA TEXT NOT NULL,
                                        MALOAIMON INTEGER NOT NULL,
                                        FOREIGN KEY (MALOAIMON) REFERENCES LOAIMON(MALOAIMON) ON DELETE CASCADE)";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS TRANGTHAIBAN(
                                        MATRANGTHAIBAN INTEGER PRIMARY KEY,
                                        TENTRANGTHAIBAN TEXT NOT NULL)";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS TANG(
                                         TANG INTEGER PRIMARY KEY)";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS BAN(
                                        MABAN INTEGER NOT NULL,
                                        TANG INTEGER NOT NULL,
                                        SIZEBAN TEXT NOT NULL,
                                        MATRANGTHAIBAN INTEGER NOT NULL,
                                        PRIMARY KEY(MABAN, TANG),
                                        FOREIGN KEY(TANG) REFERENCES TANG(TANG) ON DELETE CASCADE ON UPDATE CASCADE,
                                        FOREIGN KEY(MATRANGTHAIBAN) REFERENCES TRANGTHAIBAN(MATRANGTHAIBAN) ON DELETE CASCADE
                                        ON UPDATE CASCADE)";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS DATBAN(
                                        MADATBAN INTEGER NOT NULL,
                                        MABAN INTEGER NOT NULL,
                                        TANG INTEGER NOT NULL,
                                        THOIGIANVAO INTEGER NOT NULL,
                                        THOIGIANRA INTEGER,
                                        PRIMARY KEY(MADATBAN, MABAN, TANG),
                                        FOREIGN KEY(MABAN, TANG) REFERENCES BAN(MABAN, TANG))";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS KHACHHANG(
                                        MAKH INTEGER PRIMARY KEY,
                                        TENKH TEXT NOT NULL,
                                        SDT TEXT NOT NULL,
                                        EMAIL TEXT)";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS ORDERTAIQUAY(
                                        MAORDERTQ INTEGER NOT NULL,
                                        MAKH INTEGER NOT NULL,
                                        GHICHU TEXT,
                                        MABAN INTEGER,
                                        TANG INTEGER,
                                        PRIMARY KEY(MAORDERTQ, MAKH),
                                        FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
                                        FOREIGN KEY(MABAN, TANG) REFERENCES BAN(MABAN, TANG))";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS DSMONORDERTQ(
                                        MAMON INTEGER NOT NULL,
                                        MAORDERTQ INTEGER NOT NULL,
                                        MAKH INTEGER NOT NULL,
                                        SOLUONG INTEGER NOT NULL DEFAULT 1,
                                        SIZE TEXT,
                                        PRIMARY KEY(MAMON, MAORDERTQ, MAKH),
                                        FOREIGN KEY(MAORDERTQ, MAKH) REFERENCES ORDERTAIQUAY(MAORDERTQ, MAKH),
                                        FOREIGN KEY(MAMON) REFERENCES MON(MAMON))";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS ORDERTAIBAN(
                                        MAORDERTB INTEGER NOT NULL,
                                        MAKH INTEGER NOT NULL,
                                        MABAN INTEGER NOT NULL,
                                        TANG INTEGER NOT NULL,
                                        GHICHU TEXT,
                                        PRIMARY KEY(MAORDERTB, MAKH, MABAN, TANG),
                                        FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
                                        FOREIGN KEY(MABAN, TANG) REFERENCES BAN(MABAN, TANG))";
                    command.ExecuteNonQuery();
                }

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS DSMONORDERTB(
                                        MAORDERTB INTEGER NOT NULL,
                                        MAKH INTEGER NOT NULL,
                                        MABAN INTEGER NOT NULL,
                                        TANG INTEGER NOT NULL,
                                        MAMON INTEGER NOT NULL,
                                        SOLUONG INTEGER NOT NULL DEFAULT 1,
                                        SIZE TEXT,
                                        PRIMARY KEY(MAORDERTB, MAKH, MABAN, TANG, MAMON),
                                        FOREIGN KEY(MAORDERTB, MAKH, MABAN, TANG) REFERENCES ORDERTAIBAN(MAORDERTB, MAKH, MABAN, TANG),
                                        FOREIGN KEY(MAMON) REFERENCES MON(MAMON))";
                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
