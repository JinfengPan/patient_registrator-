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

        public void Export()
        {
            //创建workbook，说白了就是在内存中创建一个Excel文件
            IWorkbook workbook = new HSSFWorkbook();
            //要添加至少一个sheet,没有sheet的excel是打不开的
            ISheet sheet1 = workbook.CreateSheet("sheet1");

            IRow row1 = sheet1.CreateRow(0);//添加第1行,注意行列的索引都是从0开始的

            ICell cell1 = row1.CreateCell(0);//给第1行添加第1个单元格
            cell1.SetCellValue("hello npoi!");//给单元格赋值
            //上边3个步骤合在一起：sheet1.CreateRow(0).CreateCell(0).SetCellValue("hello npoi");

            //获取第一行第一列的string值
            Console.WriteLine(sheet1.GetRow(0).GetCell(0).StringCellValue); //输出：hello npoi

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