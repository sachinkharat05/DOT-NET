
//   Concrete Class म्हणजे पूर्णपणे Implement केलेला Class ज्याचा new Keyword वापरून एक किंवा अनेक Objects तयार करता येतात.

public class Person    //public → हा Class कुठूनही Access करता येतो.
{
    public string FirstName{get;set;}    // FirstName नावाचा Property तयार केलाpublic → कुठूनही Access करता येतो.
//string → Text Store करतो.get → Value वाचण्यासाठी.set → Value बदलण्यासाठी.
    public string LastName{get;set;}     // LastName Property तयार केला.
    public Person() {               // हा Default Constructor आहे.

    }
    public Person(string fname, string lname){ // हा Parameterized Constructor आहे.
      this.FirstName=fname;  //  या Object च्या FirstName Property मध्ये fname ची Value ठेव.
      this.LastName=lname;   //  Object च्या LastName Property मध्ये lname ची Value ठेव.
    }
  }