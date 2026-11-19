/*
public void Attack()
{
    Console.WriteLine("공격!");
}
자바에서는 보통 attack()처럼 작성하지만 C#에서는 Attack()처럼 작성하는 관례가 있다

-------------------------------------------------------------------------------------------------------------

Player player = new Player("용사", 100); // 객체 생성

player.ShowInfo();

class Player // 클래스
{
    string name; // 필드
    int hp;      // 필드

    public Player(string name, int hp) // 생성자
    {
        this.name = name; // this
        this.hp = hp;     // this
    }

    public void ShowInfo()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("체력: " + hp);
    }
}

---------------------------------------------------------------------------------------------------------

Player player = new Player("용사", 100);

player.Attack();
player.Attack(50);
player.Attack("검");

player.Heal();
player.Heal(100);

player.showinfo();

class Player
{
    string name;
    int hp;
    public Player(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
    public void Attack()
    {
        Console.WriteLine("기본 공격!");
    }

    public void Attack(int damage)
    {
        Console.WriteLine("공격력: " + damage);
    }

    public void Attack(string weapon)
    {
        Console.WriteLine(weapon + "으로 공격!");
    }

    public void Heal()
    {
        Console.WriteLine("체력을 회복 합니다");
    }

    public void Heal(int amount)
    {
        Console.WriteLine("회복력: " + amount);
    }

    public void showinfo()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("체력: " + hp);
    }
}
*/

// get: 값을 가져오는 기능
// set: 값을 변경하는 기능
// 예를 들자면 다음과 같이 사용이 가능 하다

Player player = new Player();

player.Hp = 100;

Console.WriteLine(player.Hp);

class Player
{
    public int Hp { get; set; }
}