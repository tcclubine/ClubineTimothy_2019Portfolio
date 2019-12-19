/** Timothy Clubine
    WDD229-O
    Final Project
    12/18/2019
**/

var player = null;
var monsterList = null;
var json = new JSON();
monsterList = JSON.parse();

var programLoop = true;
do {
    Title();
    let input = prompt(MainMenu(player)).toLowerCase();

    switch(input)
    {
        case "h":
        case "create hero":
        case "hero":
            player = CreateHero(player);
            break;
        case "c":
        case "change class":
        case "class":
            if (PlayerNullCheck(player))
            {
                player = ChooseClass(player, player.Name);
            }
            break;
        case "f":
        case "fight monsters!":
        case "fight":
            if (PlayerNullCheck(player) )
            {
                if (monsterList.Count > 0)
                {
                    monsterList = Fight(player, monsterList);
                }
                else
                {
                    console.log("The monsters have respawned.");

                    monsterList = json.CreateMonsterList();
                    monsterList = Fight(player, monsterList);
                }

            }
            break;
        case "x":
        case "exit":
            programLoop = false;
            break;
        default:
            DefaultMenuMessage(input);
            break;

    }

}while(programLoop);

//Menus
function FightMenu(){
    let fMenu = "------FIGHT!------\r\n"+
        "[a] Attack \r\n" +
        "[s] Use Skill \r\n" +
        "[r] Run Away \r\n" +
        "-----------------------------\r\n" +
        "Choose an action: "

    return fmenu;
};
function ClassMenu(){
    let menu ="-----------" +
    "   Class   " +
    "-----------\r\n" +
    "[W] Warrior \r\n" +
    "[A] Archer \r\n" +
    "[Z] Wizard \r\n" +
    "---------------\r\n" +
    "Choose a class: ";
    return menu;
};
function MainMenu(p){
    let menuString = "";
    if (p != null)
    {
        menuString += "Welcome " + p.Name + " the "+ p.ClassType +"!\r\n";
    };

    menuString +=
        "[H] Create Hero\r\n" +
        "[C] Change Class\r\n" +
        "[F] Fight Monsters!\r\n" +
        "\r\n" +
        "[X] Exit\r\n" +
        "---------------------------------------------\r\n" +
        "Choose an option to continue: ";

    return menuString;
};
function Title(){
    let title =
        " __  __                 _               _____ _                                     \r\n" +
        "|  \\/  |               | |             / ____| |                                   \r\n" +
        "| \\  / | ___  _ __  ___| |_ ___ _ __  | (___ | | __ _ _   _  ___ _ __              \r\n" +
        "| |\\/| |/ _ \\| '_ \\/ __| __/ _ \\ '__|  \\___ \\| |/ _` | | | |/ _ \\ '__|       \r\n" +
        "| |  | | (_) | | | \\__ \\ | | __/ |     ____) | | (_| | |_| | |__/ |               \r\n" +
        "|_|  |_|\\___/|_| |_|___/\\__\\___|_|    |_____/|_|\\__,_|\\__, |\\___|_|           \r\n" +
        "                                                       __/ |                        \r\n" +
        "                                                      |___/                         \r\n" +
        "__________________________________________________________________________          \r\n";
    alert(title);

};

//Utility
function DefaultMenuMessage(input){
    let msg = "\""+input +"\" is not a valid command.";
    alert(msg);
};

/**
 * @return {boolean}
 */
function PlayerNullCheck(p){
    if (p === null)
    {
        alert("You must create a hero first.");
        return false;
    }
    else
    {
        return true;
    }
};

/** Main Program Functions */
function CreateHero(p){
    let name = null;
    do
    {
        if (p === null)
        {

            name = prompt("Enter a name for your Hero: ");
            if (typeof name === 'undefined' || name == null)
            {
                alert("Do not leave blank. ");
            }
        }
        else
        {

            Console.Write();
            let input = prompt("Warning! This will override your current Hero.\r\n" +
            "Proceed? (y/n)").toLowerCase();
            switch (input)
            {
                case "y":
                case "yes":
                    p = null;
                    break;
                case "n":
                case "no":
                    return p;
                default:
                    break;
            }
        }

    } while (typeof name === 'undefined' || name == null);



    p = ChooseClass(p, name);


    return p;
};
function ChooseClass(p, name){
    do
    {
        ClassMenu();
        let input = prompt(ClassMenu()).toLowerCase();

        switch (input)
        {
            case "w":
            case "warrior":
                p = new Warrior(name);
                return p;
            case "a":
            case "archer":
                p = new Archer(name);
                return p;
            case "z":
            case "wizard":
                p = new Wizard(name);
                return p;
            default:
                alert("\""+input+"\" is not an available class.");
                break;
        }

    } while (true);
};
function Fight(player, mList){
    let fightLoop = true;
    let dmg = -1;
    // turn counter
    let turn = 1;
    do
    {
        let m = mList[0];
        let menuLoop = true;
        do
        {
            menuLoop = false;
            console.log(player.Name+"'s Health: "+player.Health);
            // Declare monster to player
            alert(m.Description);

            // create player turn
            let input = prompt(FightMenu()).toLowerCase();
            switch (input)
            {
                case "a":
                case "attack":
                    dmg = player.Attack - m.Armor;
                    DamageCalc(dmg, m);
                    break;
                case "s":
                case "use skill":
                case "skill":
                    dmg = player.Skill() - m.Armor;
                    DamageCalc(dmg, m);
                    break;
                case "r":
                case "run away":
                case "run":
                    alert("You successfully ran away. The "+m.Name+" regains it's health while it waits for your return.");
                    m.Health = 100;
                    player.Health = 100;
                    fightLoop = false;
                    break;
                default:
                    menuLoop = true;
                    DefaultMenuMessage(input);
                    break;
            }

        } while (menuLoop);

        if (m.Health < 1)
        {
            alert("You have slain the "+m.Name+"!");
            turn = 1;
            mList.pop();
        }
        else
        {
            if (fightLoop)
            {
                // create monster turn
                m.MonsterAttack(player, turn);
                if (player.Health < 1)
                {
                    alert("You have died.");
                    fightLoop = false;
                    m.Health = 100;
                    player.Health = 100;

                }
                // resolve turn
                turn += 1;
                if (!player.CanIBeAttacked)
                {
                    player.Status();
                }

            }

        }


    } while (fightLoop && mList.length > 0);

    if (mList.length < 1 && player.Health > 0)
    {
        alert("Congratulations! You have slain all of the monsters.");

    }

    return mList;
};
function DamageCalc(dmg,m){
    if (dmg < 1)
    {
        alert("You do no damage. The "+m.Name+"'s armor is too strong.");

    }
    else
    {
        alert("You do "+dmg+" damage to the "+m.Name+".");

        m.Health -= dmg;
    }
};

/** Classes */
