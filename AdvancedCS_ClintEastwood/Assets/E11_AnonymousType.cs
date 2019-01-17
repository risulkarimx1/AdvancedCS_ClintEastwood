using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class E11_AnonymousType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var people = new List<PersonY>
        {
            new PersonY{ FirstName = "John", LastName = "Doe", age =50},
            new PersonY{ FirstName = "Jane", LastName = "Doe", age =24},
            new PersonY{ FirstName = "Robert", LastName = "Williams", age =44},
            new PersonY{ FirstName = "Bob", LastName = "Walter", age =12},
            new PersonY{ FirstName = "Chuck", LastName = "Norris", age =12}
        };

        var res = from p in people
                  where p.LastName == "Doe" && p.age > 30
                  select new { pNmae = p.LastName,   pAge = p.age};
        //group p by p.LastName;
        foreach (var r in res)
        {
            Debug.Log(r.pNmae+" "+r.pAge);
            
        }
    }
}

public class PersonY
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int age { get; set; }

    public override string ToString()
    {
        return $"Name {FirstName} {LastName} and age is {age}";
    }
}

