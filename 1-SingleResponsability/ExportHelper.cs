using System.Collections;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper<T>
    {
        public void ExportsStudentsCsv(IEnumerable<T> students)
        {
            //string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            var sb = new System.Text.StringBuilder();
            // Se obtienen las propiedades del objeto genérico
            var properties = typeof(T).GetProperties();
            var headers = string.Join(";", properties.Select(p => p.Name));
            sb.AppendLine(headers);

            foreach (var item in students)
            {
                string line = string.Empty;
                foreach (var prop in properties)
                {
                    object? value = prop.GetValue(item, null);

                    if (value is null) continue;

                    if (value is not string && value is IEnumerable valuearray)
                    {
                        var values = valuearray.Cast<object>().Select(v => v);
                        line += string.Join("|", values);
                        continue;
                    }

                    line += $"{value};";
                }
                sb.AppendLine(line);

                System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
            }

        }
    }
}