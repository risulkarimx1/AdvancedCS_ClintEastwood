using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class E10_LINQQ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //var sampleLine = "I just like dancing in the wind and go home asap";
        //var result = from c in sampleLine.ToLower()
        //             where c=='a' || c == 'e' || c == 'i' || c == 'o' || c == 'o'
        //             //orderby c descending
        //             group c by c; 
        //             //select c;  
        //foreach(var r in result)
        //{
        //    Debug.Log(r.Key);
        //}

        var people = new List<PersonX>
        {
            new PersonX{ FirstName = "John", LastName = "Doe", age =50},
            new PersonX{ FirstName = "Jane", LastName = "Doe", age =24},
            new PersonX{ FirstName = "Robert", LastName = "Williams", age =44},
            new PersonX{ FirstName = "Bob", LastName = "Walter", age =12},
            new PersonX{ FirstName = "Chuck", LastName = "Norris", age =12}
        };

        var res = from p in people
                  where p.LastName == "Doe" && p.age > 30
                  select p;
        //group p by p.LastName;
        foreach (var r in res)
        {
            Debug.Log(r);
        }
    }
}

public class PersonX
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int age { get; set; }

    public override string ToString()
    {
        return $"Name {FirstName} {LastName} and age is {age}";
    }
}
