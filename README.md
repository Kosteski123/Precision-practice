# Precision-practice 

1 how to play with pics
2 classes with code quoted with '''
scene pa circles pa form1 i posle so samite side features

## Explanation od this Readme file: 
Овој readme file ке има топ даун пристап каде ќе почне со кратко упатстцво на играње со слики и после ќе кажам како точно сите ја испрограмиравме играта.

Ready, епа среќно читање!

## How to play the Precision practice game 
Поентата на играта не е да се игра, туку да си ги тестираш твоите способности и рефлекси

Треба да кликаш на крукчиња кои се појавуваат откако ќе ги кликнеш или откако ќе истече тајмерот за нив

Како се бришат крукчињата така и тие се појавуваат побрзо (тајмерот одоздола ќе се намалува со секое поминато крукче)

Под поминато крукче се мисли или кликнато или истечен тајмер за него. Кога ќе стигне тајмерот до 500 ms тогаш победуваш ако имаш животи останато
## Start screen

![Screenshot (9)](https://user-images.githubusercontent.com/63061280/86637730-5c42a700-bfd6-11ea-95b6-6e90d42c7725.png)
На почеток ќе има старт скрин каде ќе најдете:

- start game button

- list of quests with lable Quests

- ? button that opens a how to play window

## After pressing the Start game button

![Screenshot (6)](https://user-images.githubusercontent.com/63061280/86637948-b9d6f380-bfd6-11ea-9753-fc4b47dda27b.png)
**Ќе има countdown од 3 2 1 Get Ready па ќе почнат крукчиња да се појавуваат како на сликата**

Исто така ќе се појават combo и lives counter.

![Screenshot (7)](https://user-images.githubusercontent.com/63061280/86638224-35d13b80-bfd7-11ea-9637-1f19d1f6e486.png)
 Овие крукчиња можеш да ги кликнеш каде ќе ти се зголеми combo counterот за 1 кога ќе кликнеш крукчиња по ред.
 
 Ако промашиш едно (ова значи misclick или кликање на нешто што не е крукче), тогаш ќе ти се ресетира combo counterот на 0 и ќе изгубиш еден живот : (
 
 Поентата е да се тестираш колку брзи ти се рефлексите, а не колку крукчиња можеш да кликнеш.
 
 Ако успееш да ги изгубиш сите животи, тогаш ќе ти се појави You lose screen каде ти покажува колку добро си поминал.
 
 ![Screenshot (8)](https://user-images.githubusercontent.com/63061280/86638793-34ecd980-bfd8-11ea-892c-c6249587ad8f.png)
 
  **Key note: Кога играш некогаш ќе изгледа како да има некој bug  каде кликаш крукче и веднаш после се појавува друго па пак друго и губиш живот. Ова не е bug, само значи дека си прелош >:D. Но ова е бидејќи си пробал да го кликнеш крукчето, но додека го кликнеш се појавило друго, а ти веќе си кликнал друго пред да забележиш. Затоа е ефектот на 2 крукчиња па губиш живот.**
  
  После You Lose можеш да пробаш пак да играш со Restart game копчето каде само ја рестартира играта и пак те носи на првиот screen/form.
  
  ## Some insight on how the code works and how the game is implemented
  
  Кодот е составен од генерално 3 класи кои се Circles, Scene и Form1.
  
  Класата circles е првата и најосновната каде се цртаат самите крукчиња и се проверува дали се кликнати точно.
  
  Првин се градат крукчињата со помош на Draw методот и за таа цел има променливи:
  - За боја ColorInner и ColorOutter
  - Random r за да се најде произволна позиција на формата
  - Center за центарот на крукчето
  
  Другиот метод што е важен е методот Clicked кој проверува што е кликнато точно. Дали е кликнато негде во координатите на крукчето или некаде надвор од него. 

  '''
  public class Circles
    {  
        //public Point SecondCenter { get; set; }
        public Point Center { get; set; }
        public Color ColorInner;
        public Color ColorOutter;
        public Random r;
        public static int radius = 40;
        public Circles(Point center)
        {
            r = new Random();
            Center = center;
            ColorInner = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));//random color
            ColorOutter = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        public void Draw(Graphics g) {
            Brush b1 = new SolidBrush(ColorOutter); 
            Brush b2 = new SolidBrush(ColorInner);
            Brush b3 = new SolidBrush(Color.Black);
            g.FillEllipse(b1, Center.X - radius, Center.Y - radius, 2 * radius, 2 * radius);//outter
            g.FillEllipse(b3, Center.X - radius + 8, Center.Y - radius + 8, (2 * radius) - 16, (2 * radius) - 16);//separator
            g.FillEllipse(b2, Center.X - radius+10, Center.Y - radius+10, (2 * radius) - 20, (2 * radius) -20);//inner
            b1.Dispose();
            b2.Dispose();
            b3.Dispose();
        }

        public bool Clicked(int x, int y)
        {
            int  diff = (Center.X - x) * (Center.X - x) + (Center.Y - y) * (Center.Y - y);
            return diff <= radius * radius;
        }
    }
 
 Следниот дел од код е калсата Scene која ја претставува самата сцена или состојба на играта.
 Оваа класа ги чува крукчињата на сцената, бројот на животи преостанати, combo counterот и max combo in game како flagMax.
  
 Крукчињата се додаваат во самата листа од кругови како што се креираат. Тие се креираат кога ќе кликнеш било што (круг или формата) или кога ќе истече тајмерот за кругот.
 Вака самата сцена може да чува информации за што се случува во играта како дали играчот има изгубено живот, колку му е combo и колкаво е неговиот max combo за оваа партија.
 
 '''
 public class Scene
    {
        public List<Circles> circles { get; set; }
        public int Combo { get; set; }
        public int flagMax { get; set; }
        public int threeLives { get; set; }


        public Scene()
        {
            circles = new List<Circles>();
            Combo = 0;
            flagMax = 0;
            threeLives = 3;
        }
        public void Draw(Graphics g)
        {
            foreach(Circles c in circles) {
                c.Draw(g);
            }
        }
        
        public void addC(Circles c)
        {
            circles.Add(c);
        }
        
        public void Click(int x, int y) {
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].Clicked(x, y))
                {
                    Combo++;
                    circles.RemoveAt(i);
                    if (Combo > flagMax)
                        flagMax = Combo;
                }
                else
                {
                    threeLives--;
                    Combo = 0;
                    circles.RemoveAt(i);
                }
            }
        }
        public void removeC() 
        {
            for (int i = 0; i < circles.Count-1; i++)
                circles.RemoveAt(i);
        }

        internal void removeAllC()
        {
            for (int i = 0; i < circles.Count; i++)
                circles.RemoveAt(i);
        }
    }
 
 За листата од кругови имаме соодветни методи имплементирано што само додаваат и бришат елементи или ја брише целата листа.
 Методите се:
 - removeC()
 - removeAll()
 - addC()
 
 Методата Draw тука ја повикува Draw методата од крукчињата за сите кгуови во листата so for each
 
 Методата Click проверува тука дали е добро кликнато кругчето и ако е, тогаш прави зголемување на combo и flagMax го заменува со combo ако види дека има ново најголемо combo постигнато оваа партија.
 
 Ако не е кликнато копче туку нешто друго, тогаш одзема еден живот и го ресетира combo на нула пак.
 
 Form1 служи како main методата тука и ги има имплементирано почетокот, крајот на играта, другите функционалности (како quests и game over screenот), појавувањето на крукчиња итн
 
 
 '''
 private void timerPlay_Tick(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            comboLabel.Visible = true;
            livesLabel.Visible = true;
            timerPlay.Interval = decrease;
            timerSpeedLabel.Text = string.Format("Timer Speed: " + decrease + "ms");
            if (decrease >= 1000)
                decrease -= 50;
            else if (decrease < 1000)
                decrease -= 20;
            timerPlay.Interval = decrease;
            int y = r.Next(2 * Circles.radius, Height - (Circles.radius * 2));      //random loc
            int x = r.Next(2 * Circles.radius, Width - (Circles.radius * 2));
            Circles c = new Circles(new Point(x, y));
            scene.addC(c);
            comboLabel.Text = string.Format("Combo: " + scene.Combo);

            if (scene.threeLives >= 0)
            {
                livesLabel.Text = string.Format("♥ x " + scene.threeLives);
            }
            else
            {
                //scene.removeAllC();
                timerPlay.Stop();
                this.BackColor = Color.DarkGray;
                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                gameOverLabel.Text = string.Format(lose + scene.flagMax);
                restartBtn.Visible = true;
                restartBtn.Enabled = true;
                inGameQ1.BackColor = Color.DarkGray;
                inGameQ2.BackColor = Color.DarkGray;
                scene.removeAllC();
                flag = 1;
            }
            if (timerPlay.Interval < 500)
            {
                scene.removeAllC();                             //*   treba dvapati da ja ima ovaa funkcija za da raboti
                timerPlay.Stop();
                this.BackColor = Color.DarkGray;
                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                gameOverLabel.Text = string.Format(win + scene.flagMax);
                restartBtn.Visible = true;
                restartBtn.Enabled = true;
                inGameQ1.BackColor = Color.DarkGray;
                inGameQ2.BackColor = Color.DarkGray;
                scene.removeAllC();                              //*
                flag = 1;
            }
            this.checkQuests(); //proveruva dali se postignati samite quests
            scene.removeC();
            Invalidate(true);
        }
 Крукчињата се појавуваат на секој тајмер tick каде се појавуваат нови крукчиња се контролира:
 - брзината на појавување на куговите
 ```
 int y = r.Next(2 * Circles.radius, Height - (Circles.radius * 2));      //random loc
            int x = r.Next(2 * Circles.radius, Width - (Circles.radius * 2));
            Circles c = new Circles(new Point(x, y));
            scene.addC(c);
 ```
 - се проверува за крај на играта 
 ```
 if (timerPlay.Interval < 500)
            {
                scene.removeAllC();                             //*   treba dvapati da ja ima ovaa funkcija za da raboti
                timerPlay.Stop();
                this.BackColor = Color.DarkGray;
                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                gameOverLabel.Text = string.Format(win + scene.flagMax);
                restartBtn.Visible = true;
                restartBtn.Enabled = true;
                inGameQ1.BackColor = Color.DarkGray;
                inGameQ2.BackColor = Color.DarkGray;
                scene.removeAllC();                              //*
                flag = 1;
            }
 ```
 - дали имаме уште животи 
 ```
 if (scene.threeLives >= 0)
            {
                livesLabel.Text = string.Format("♥ x " + scene.threeLives);
            }
            else
            {
                //scene.removeAllC();
                timerPlay.Stop();
                this.BackColor = Color.DarkGray;
                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                gameOverLabel.Text = string.Format(lose + scene.flagMax);
                restartBtn.Visible = true;
                restartBtn.Enabled = true;
                inGameQ1.BackColor = Color.DarkGray;
                inGameQ2.BackColor = Color.DarkGray;
                scene.removeAllC();
                flag = 1;
            }
 ```
 - Ја контролира брзината на појавување на круговите
 ```
 if (decrease >= 1000)
                decrease -= 50;
            else if (decrease < 1000)
                decrease -= 20;
 ```
 Друго нешто што прави формата е: 
 - При клик ја поовикува scene.Click и дава ново копче
  ```
  private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (startGame.Visible == false && timerCountDown.Enabled == false && flag == 0)
            {
                scene.Click(e.X, e.Y);
                scene.removeC();
                timerPlay_Tick(null, null); // Za da se pojavi novo krukce se povikuva pak timerPlay_Tick
            }
        }
  ```
  - Ја имплементира логиката за how to play копчето
  ```
  private void pictureBox1_Click(object sender, EventArgs e)
        {
            howToPlayWindow.ShowDialog();
        }
  ```
  - Ја имплементира логиката за restart game копчето при game over screenот
  ```
  private void restartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
  ```
  - Ја имплементира логиката на клик на start game копчето со овој код
  ```
  private void startGame_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            titleLabel.Visible = false;
            titleLabel.Enabled = false;
            startGame.Visible = false;      //button
            startGame.Enabled = false;
            // ruleLabel.Visible = false;
            // ruleLabel.Enabled = false;
            pictureBox1.Visible = false;
            questsLable.Visible = false;
            q1.Visible = false;         //remove the quest labels to reduce visual clutter
            q1.Enabled = false;
            q2.Visible = false;
            q2.Enabled = false;
            timerCountDown.Start();
        }
  ```
  - Тој countdown od 3 2 1 Get Ready! е опишан со овој код
  ```
  private void timerCountDown_Tick(object sender, EventArgs e)
        {
            countDownLabel.Visible = true;
            flagStart--;
            countDownLabel.Text = flagStart.ToString();
            if (flagStart == 0)
            {
                countDownLabel.Text = "Get Ready!!!";
            }
            else if (flagStart == -1)
            {
                countDownLabel.Visible = false;
                timerCountDown.Stop();
                timerPlay.Start();
            }

        }
  ```
  - Има исто така и side quests кои се ставени во кодот за да се имплементира функционалтноста за quests. Тие се таму само за дополнителен предизвик, но нема поени. Ако ги исполни, тогаш ќе имаш индикатор од десната горна страната со мали сликички дека ти е исполнет. Прво треба да се креираат и изберат кои quests ќе бидат за оваа партија. Има 6 каде при секоја нова партија има нови 2 quests кои се различни. Со помош на овој код се генерираат 2 различни quests.
  ```
  quest1 = r.Next(6);
            while (true)               //ovoj while e za da se vidi dali se izbrani razlicni quests
            {
                quest2 = r.Next(6);
                if (quest2 != quest1)
                {
                    break;
                }
            }
            this.quest(quest1, quest2);
  ```
  А со овој код се менува текстот кај Quests лабелата:
  ```
  private void quest(int quest1, int quest2)
        {
            //Ovaa funkcija e za da se setira labelata za quests pod Start game kopceto!
            switch (quest1)
            {
                case 0:
                    q1.Text = "Get a max combo of 20 circles in a row!";
                    break;
                case 1:
                    q1.Text = "Complete the game with 3 lives!";
                    break;
                case 2:
                    q1.Text = "Complete the game with 2 lives remaining!";
                    break;
                case 3:
                    q1.Text = "Get a max combo of 25 circles in a row!";
                    break;
                case 4:
                    q1.Text = "Reach a speed of 600 or less!";
                    break;
                default:
                    q1.Text = "Reach a speed of 1000 or less!";
                    break;
            }
            switch (quest2)
            {
                case 0:
                    q2.Text = "Get a max combo of 20 circles in a row!";
                    break;
                case 1:
                    q2.Text = "Complete the game with 3 lives!";
                    break;
                case 2:
                    q2.Text = "Complete the game with 2 lives remaining!";
                    break;
                case 3:
                    q2.Text = "Get a max combo of 25 circles in a row!";
                    break;
                case 4:
                    q2.Text = "Reach a speed of 600 or less!";
                    break;
                default:
                    q2.Text = "Reach a speed of 1000 or less!";
                    break;
            }
        }
  ```
  
  Формата 2 го претставува how to play текстот и се иницијализира од почетокот со:
  ```
  private Form2 howToPlayWindow = new Form2();
  ```
  Логиката за копчето ? кое го пушта овој прозор е дадена погоре.
  Се надевам дека ова readme го појасни малку кодот, но генерално иде вака:
  - Се почнува со кликање на start game
  - Се појавува тајмер со 3 2 1 Get ready!
  - Почнува играта каде се појавуваат нови кругови со клик некаде на формата. Ако е на круг се зголемува combo и не се губи живот threeLives во scene
  - Ако е промашено се ресетира combo и се намалува threeLives или еден живот
  - Ако успееш да стигнеш до тајмерот да биде 500 ms брзина на појавување на кругови со сите 3 животи, тогаш победуваш и можеш пак да играш
  - Ако снемаш живпти, тогаш губиш и можеш да почнеш одпоново
  - Можеш и да исполниш quests кои се различни секоја партија и има индикатор во горниот десен агол за дали се исполнети
  - ? копчето отвара друг прозор со инструкции за играње
  Фала за читањето и Good Luck Have Fun!
 
