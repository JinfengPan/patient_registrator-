namespace PatientRegistrator.UI.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using NPOI.HSSF.UserModel;
    using NPOI.SS.UserModel;

    using PatientRegistrator.DataAccess;
    using PatientRegistrator.Model;


    public class PatientDataService : IPatientDataService
    {
        private CoreContext _coreContext;

        public PatientDataService(CoreContext context)
        {
            this._coreContext = context;
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await this._coreContext.Patients.AsNoTracking().ToListAsync();
        }

        public async Task<Patient> GetByIdAsync(int patientId)
        {
            return await this._coreContext.Patients.SingleAsync(p => p.Id == patientId);
        }

        public async Task SaveAsync()
        {
            await this._coreContext.SaveChangesAsync();
        }

        public void Add(Patient patient)
        {
            this._coreContext.Add(patient);
        }

        public void Remove(Patient patient)
        {
            this._coreContext.Remove(patient);
        }

        public async void Export()
        {
            //创建workbook，说白了就是在内存中创建一个Excel文件
            IWorkbook workbook = new HSSFWorkbook();
            //要添加至少一个sheet,没有sheet的excel是打不开的
            ISheet sheet1 = workbook.CreateSheet("sheet1");

            IRow row0 = sheet1.CreateRow(0);//添加第1行,注意行列的索引都是从0开始的

            for (int i = 0; i < headers.Length; i++)
            {
                ICell cell1 = row0.CreateCell(i);//给第1行添加第1个单元格
                cell1.SetCellValue(headers[i]);//给单元格赋值
            }

            var patients = await this.GetAllAsync();

            for (int i = 0; i < patients.Count; i++)
            {
                IRow row = sheet1.CreateRow(i + 1);

                row.CreateCell(0);
                row.CreateCell(1); 
                row.CreateCell(2);
                row.CreateCell(3);
                row.CreateCell(4);
                row.CreateCell(5);
                row.CreateCell(6);
                row.CreateCell(7);
                row.CreateCell(8);
                row.CreateCell(9);
                row.CreateCell(10);
                row.CreateCell(11);
                row.CreateCell(12);
                row.CreateCell(13);
                row.CreateCell(14);
                row.CreateCell(15);
                row.CreateCell(16);
                row.CreateCell(17);
                row.CreateCell(18);
                row.CreateCell(19);
                row.CreateCell(20);
                row.CreateCell(21);
                row.CreateCell(22);
                row.CreateCell(23);
                row.CreateCell(24);
                row.CreateCell(25);
                row.CreateCell(26);
                row.CreateCell(27);
                row.CreateCell(28);
                row.CreateCell(29);
                row.CreateCell(30);
                row.CreateCell(31);
                row.CreateCell(32);
                row.CreateCell(33);
                row.CreateCell(34);
                row.CreateCell(35);
                row.CreateCell(36);
                row.CreateCell(37);
                row.CreateCell(38);
                row.CreateCell(39);
                row.CreateCell(40);
                row.CreateCell(41);
                row.CreateCell(42);
                row.CreateCell(43);
                row.CreateCell(44);
                row.CreateCell(45);
                row.CreateCell(46);
                row.CreateCell(47);
                row.CreateCell(48);
                row.CreateCell(49);
                row.CreateCell(50);
                row.CreateCell(51);
                row.CreateCell(52);
                row.CreateCell(53);
                row.CreateCell(54);
                row.CreateCell(55);
                row.CreateCell(56);
                row.CreateCell(57);
                row.CreateCell(58);
                row.CreateCell(59);
                row.CreateCell(60);
                row.CreateCell(61);
                row.CreateCell(62);
                row.CreateCell(63);
                row.CreateCell(64);
                row.CreateCell(65);
                row.CreateCell(66);
                row.CreateCell(67);
                row.CreateCell(68);
                row.CreateCell(69);
                row.CreateCell(70);
                row.CreateCell(71);
                row.CreateCell(72);
            }
            

            //写入文件
            using (FileStream file = new FileStream(@"D:/TestFiles/test.xls", FileMode.Create))
            {
                workbook.Write(file);
            }
        }

        private static string[] headers = new string[]
                                              {
                                                  "姓名",
                                                  "年龄",
                                                  "性别",
                                                  "籍贯",
                                                  "主要表现",
                                                  "病程",
                                                  "头痛",
                                                  "抽搐",
                                                  "意识障碍",
                                                  "肢体偏瘫",
                                                  "大小便失禁",
                                                  "视力",
                                                  "糖尿病",
                                                  "高血压",
                                                  "痛风",
                                                  "羊癫疯",
                                                  "其他1",
                                                  "头痛",
                                                  "抽搐",
                                                  "意识障碍",
                                                  "肢体偏瘫",
                                                  "大小便失禁",
                                                  "白细胞",
                                                  "D-二聚体",
                                                  "白蛋白",
                                                  "降钙素原",
                                                  "血沉",
                                                  "CRP",
                                                  "其他特殊检查1",
                                                  "其他特殊检查2",
                                                  "其他特殊检查3",
                                                  "视力视野",
                                                  "CT",
                                                  "MRI",
                                                  "其他特殊检查4",
                                                  "其他特殊检查5",
                                                  "其他特殊检查6",
                                                  "是否采用药物",
                                                  "药物类型",
                                                  "具体的药物",
                                                  "是否采用手术",
                                                  "手术方式",
                                                  "头痛",
                                                  "感染",
                                                  "出血",
                                                  "抽搐",
                                                  "二次手术",
                                                  "其他2",
                                                  "其他3",
                                                  "白细胞",
                                                  "D-二聚体",
                                                  "白蛋白",
                                                  "降钙素原",
                                                  "血沉",
                                                  "CRP",
                                                  "其他特殊检查7",
                                                  "其他特殊检查8",
                                                  "其他特殊检查9",
                                                  "视力视野",
                                                  "CT",
                                                  "MRI",
                                                  "其他特殊检查10",
                                                  "其他特殊检查11",
                                                  "其他特殊检查12",
                                                  "头痛",
                                                  "抽搐",
                                                  "偏瘫",
                                                  "其他4",
                                                  "其他5",
                                                  "其他6",
                                                  "其他7",
                                                  "生活自理程度",
                                                  "随访时间"
                                              };
    }
}