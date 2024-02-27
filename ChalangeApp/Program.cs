User user1 = new User("Adam","367482893");
User user2 = new User("Monika","74937592");
User user3 = new User("Zuzia","462928465");
User user4 = new User("Damian","29294746");

user1.Login = "Marek";
var name = user1.Login;
user1.AddScore(5);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;              // typ objektu zmienna statyczna ( constans), bez 'this.' !


class User                          t w o r z e n i e   o b j e k t u
{
   
    public static string GameName = "Diablo";
    private string login;             // już niepotrzebna zminna           
    private string password;
    private int score;
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;          // bo tu w konstruktorze odwołujemy się do property w momencie jej utworzenia i zmieniamy na wielką literę
        this.password = password;       {-----} KOSTRUKTOR
      // this.score = 0;  zbędna     // gdy utworzymy new List<>int>() nad objektem User   
    }
    public string Login { get; private set; }  //  {;;} PROPERTY - PARAMETRY
                                               // modyfikator postępu priv./ public
    public string password { get; set; }    //  ;get-pobieramy  ;set-ustawiany z zewnątrz

    public int Result { get; } // <-- set pusty!,bo będzie wywoływany z List<> score_ = , a get rozpisujemy następująco:

    public int Result
    {
        get
        {
            return this.score.Sum();
            ;-}  return = 0  !
        }
    }
    public void AddScore(int score)        M E T O D A
    {
        this.score = this.score + score;
        // this.score += score;            lub
        // this.score += number;           dla _AddScore(int number)
    }

    public void AddScore(int number)
    {
        this.score.Add(number);      // ten [i] dodaje się do __= new List<int>();        
    }
}
    
// user1.AddScore(35);
// user2.AddScore(2);
// var result = user1.Result;  Con.WrL(result); 37
   