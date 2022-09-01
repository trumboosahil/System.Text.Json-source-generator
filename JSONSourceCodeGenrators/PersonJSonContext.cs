using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSONSourceCodeGenrators
{
    [JsonSerializable(typeof(Person))]
    public partial class PersonJSonContext: JsonSerializerContext
    {
    }
}
