using System.Collections;
using System.Collections.Generic;

namespace ActiveRecord.Interface {
    /// <summary>
    /// DBの情報をオブジェクトにマッピングするインタフェース
    /// </summary>
    public interface IDataAccessObject
    {
        string tableName { get; }
        int id { get; set; }
        void Mapping(Dictionary<string, object> colomn);
    }
}