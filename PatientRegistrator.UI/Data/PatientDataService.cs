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

                row.CreateCell(0, CellType.String).SetCellValue();
                row.CreateCell(1, CellType.String).SetCellValue();
                row.CreateCell(2, CellType.String).SetCellValue();
                row.CreateCell(3, CellType.String).SetCellValue();
                row.CreateCell(4, CellType.String).SetCellValue();
                row.CreateCell(5, CellType.String).SetCellValue();
                row.CreateCell(6, CellType.String).SetCellValue();
                row.CreateCell(7, CellType.String).SetCellValue();
                row.CreateCell(8, CellType.String).SetCellValue();
                row.CreateCell(9, CellType.String).SetCellValue();
                row.CreateCell(10, CellType.String).SetCellValue();
                row.CreateCell(11, CellType.String).SetCellValue();
                row.CreateCell(12, CellType.String).SetCellValue();
                row.CreateCell(13, CellType.String).SetCellValue();
                row.CreateCell(14, CellType.String).SetCellValue();
                row.CreateCell(15, CellType.String).SetCellValue();
                row.CreateCell(16, CellType.String).SetCellValue();
                row.CreateCell(17, CellType.String).SetCellValue();
                row.CreateCell(18, CellType.String).SetCellValue();
                row.CreateCell(19, CellType.String).SetCellValue();
                row.CreateCell(20, CellType.String).SetCellValue();
                row.CreateCell(21, CellType.String).SetCellValue();
                row.CreateCell(22, CellType.String).SetCellValue();
                row.CreateCell(23, CellType.String).SetCellValue();
                row.CreateCell(24, CellType.String).SetCellValue();
                row.CreateCell(25, CellType.String).SetCellValue();
                row.CreateCell(26, CellType.String).SetCellValue();
                row.CreateCell(27, CellType.String).SetCellValue();
                row.CreateCell(28, CellType.String).SetCellValue();
                row.CreateCell(29, CellType.String).SetCellValue();
                row.CreateCell(30, CellType.String).SetCellValue();
                row.CreateCell(31, CellType.String).SetCellValue();
                row.CreateCell(32, CellType.String).SetCellValue();
                row.CreateCell(33, CellType.String).SetCellValue();
                row.CreateCell(34, CellType.String).SetCellValue();
                row.CreateCell(35, CellType.String).SetCellValue();
                row.CreateCell(36, CellType.String).SetCellValue();
                row.CreateCell(37, CellType.String).SetCellValue();
                row.CreateCell(38, CellType.String).SetCellValue();
                row.CreateCell(39, CellType.String).SetCellValue();
                row.CreateCell(40, CellType.String).SetCellValue();
                row.CreateCell(41, CellType.String).SetCellValue();
                row.CreateCell(42, CellType.String).SetCellValue();
                row.CreateCell(43, CellType.String).SetCellValue();
                row.CreateCell(44, CellType.String).SetCellValue();
                row.CreateCell(45, CellType.String).SetCellValue();
                row.CreateCell(46, CellType.String).SetCellValue();
                row.CreateCell(47, CellType.String).SetCellValue();
                row.CreateCell(48, CellType.String).SetCellValue();
                row.CreateCell(49, CellType.String).SetCellValue();
                row.CreateCell(50, CellType.String).SetCellValue();
                row.CreateCell(51, CellType.String).SetCellValue();
                row.CreateCell(52, CellType.String).SetCellValue();
                row.CreateCell(53, CellType.String).SetCellValue();
                row.CreateCell(54, CellType.String).SetCellValue();
                row.CreateCell(55, CellType.String).SetCellValue();
                row.CreateCell(56, CellType.String).SetCellValue();
                row.CreateCell(57, CellType.String).SetCellValue();
                row.CreateCell(58, CellType.String).SetCellValue();
                row.CreateCell(59, CellType.String).SetCellValue();
                row.CreateCell(60, CellType.String).SetCellValue();
                row.CreateCell(61, CellType.String).SetCellValue();
                row.CreateCell(62, CellType.String).SetCellValue();
                row.CreateCell(63, CellType.String).SetCellValue();
                row.CreateCell(64, CellType.String).SetCellValue();
                row.CreateCell(65, CellType.String).SetCellValue();
                row.CreateCell(66, CellType.String).SetCellValue();
                row.CreateCell(67, CellType.String).SetCellValue();
                row.CreateCell(68, CellType.String).SetCellValue();
                row.CreateCell(69, CellType.String).SetCellValue();
                row.CreateCell(70, CellType.String).SetCellValue();
                row.CreateCell(71, CellType.String).SetCellValue();
                row.CreateCell(72, CellType.String).SetCellValue();
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