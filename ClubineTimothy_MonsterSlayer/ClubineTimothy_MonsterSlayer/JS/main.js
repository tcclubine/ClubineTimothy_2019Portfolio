// Timothy Clubine
// WDD229-O
// Final Project
// 12/18/2019

var player = null;
var monsterList = null;
var json = new JSON();
monsterList = json.CreateMonsterList();

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
            PressToContinue();
            break;
        case "c":
        case "change class":
        case "class":
            if (PlayerNullCheck(player))
            {
                player = ChooseClass(player, player.Name);
                PressToContinue();
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
                    Console.WriteLine("The monsters have respawned.");
                    PressToContinue();
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
            PressToContinue();
            break;

    }

}while(programLoop);

function FightMenu(){
    let fMenu =
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
