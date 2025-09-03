using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class AssignSubjectForSem
    {
        public static void assignSubjectForSem(Dictionary<string, List<string>> dict)
        {
            List<string> totalSubject = new List<string>();
            foreach(var val in dict)
            {
                totalSubject.Add(val.Key);
            }
            int sem = 1;

            foreach (var val in dict)
            { 
                if (sem <= dict.Count)
                {
                       List<string> list = val.Value;
                       int n = totalSubject.Count;
                        List<string> removeList = new List<string>();
                        for (int i = 0; i < n; i++)
                        {
                            if (list.Contains(totalSubject[i]))
                            {
                                Console.WriteLine($"{sem} : {totalSubject[i]}");
                                sem++;
                                list.Remove(totalSubject[i]);
                                removeList.Add(totalSubject[i]);
                            }

                        }
                        if(totalSubject.Contains(val.Key))
                        {
                            Console.WriteLine($"{sem} : {val.Key}");
                            removeList.Add(val.Key);
                            sem++;
                        }
                        foreach (var value in removeList)
                        {
                            totalSubject.Remove(value);
                        }
                }
            }
        }
    }
}
