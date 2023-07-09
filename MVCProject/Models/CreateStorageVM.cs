using MVCProject.Entities.Concrete;

namespace MVCProject.Models
{
    public class CreateStorageVM
    {
        //public CreateStorageVM()
        //{
        //    columnNameList = new List<string>();
        //}
        public string StorageName { get; set; }
        //public string Column1Name { get; set; }
        //public string Column2Name { get; set; }
        //public string Column3Name { get; set; }
        //public string Column4Name { get; set; }
        //public string Column5Name { get; set; }
        //public string Column6Name { get; set; }
        //public string Column7Name { get; set; }
        //public string Column8Name { get; set; }

        public string[] columnNameList  { get; set; } = new string[8];
    }
}
