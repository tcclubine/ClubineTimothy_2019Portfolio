/** Timothy Clubine
    WDD229-O
    Final Project
    12/18/2019
**/

/** Classes */
class Hero {
    canIBeAttacked;
    constructor(name,classType,health,attack,armor){
        this.name = name;
        this.classType = classType;
        this.health = health;
        this.attack = attack;
        this.armor = armor;
        this.canIBeAttacked = true;

    };
    Skill(){
        let temp = -1;
        alert("Error: This is the virtual Skill()");
        return temp;
    };
    Status(){
        this.canIBeAttacked = !this.canIBeAttacked;
    };
}
class Wizard extends Hero{
    constructor(name){
        super(name,"Wizard", 100, 5, 0);
    };
    Skill(){

        let skillAttack = 100;
        alert("You cast Fireball at the monster.");
        return skillAttack;
    };
}
class Archer extends Hero{
    constructor(name){
        super(name, "Archer", 100,15,5);
    };
    Skill(){
        super.Skill();
        alert("You fire your bow and slip into the shadows evading the next attack.");
        this.Status();
        return this.attack;
    };
}
class Warrior extends Hero{
    constructor(name){
        super(name, "Warrior", 100,10,10);
    };
    Skill(){
        super.Skill();
        alert("You bolster you attack and defense.");
        this.attack += 10;
        this.armor += 10;
        return this.attack;
    };
}

/*class Monster {
    constructor(name,description,health,attack,armor){
        this.name = name;
        this.description = description;
        this.health = health;
        this.attack = attack;
        this.armor = armor;
    };

}*/

/**Main Program**/
var player = null;
var monsterList;
monsterList = JsonObj();

Title();
var programLoop = true;
do {

    let input = MainMenu(player);

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
                player = ChooseClass(player, player.name);
            }
            break;
        case "f":
        case "fight monsters!":
        case "fight":
            if (PlayerNullCheck(player) )
            {
                if (monsterList.length > 0)
                {
                    monsterList = Fight(player, monsterList);
                }
                else
                {
                    console.log("The monsters have respawned.");

                    monsterList = JsonObj();
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
/**End of Main Program**/


/**Menus**/

/**
 * @return {string}
 */
function FightMenu(){
    let msg = "------FIGHT!------\r\n"+
        "[a] Attack \r\n" +
        "[s] Use Skill \r\n" +
        "[r] Run Away \r\n" +
        "-----------------------------\r\n" +
        "Choose an action: ";

    input = prompt(msg).toLowerCase();
    return input;


}

/**
 * @return {string}
 */
function ClassMenu(){
    let msg ="-----------" +
    "   Class   " +
    "-----------\r\n" +
    "[W] Warrior \r\n" +
    "[A] Archer \r\n" +
    "[Z] Wizard \r\n" +
    "---------------\r\n" +
    "Choose a class: ";

    input = prompt(msg);

    return input;

}

/**
 * @return {string}
 */
function MainMenu(p){
    let menuString =
        "-----------------\r\n" +
        "    Main Menu    \r\n" +
        "-----------------\r\n";
    if (p !== null)
    {
        menuString += "Welcome " + p.name + " the "+ p.classType +"!\r\n";
    }

    menuString +=
        "[H] Create Hero\r\n" +
        "[C] Change Class\r\n" +
        "[F] Fight Monsters!\r\n" +
        "\r\n" +
        "[X] Exit\r\n" +
        "---------------------------------------------\r\n" +
        "Choose an option to continue: ";

    input = prompt(menuString).toLowerCase();
    return input;
}
function Title(){
    let title = "Welcome to Monster Slayer!";
    alert(title);

}

//Utility
function DefaultMenuMessage(input){
    let msg = "\""+input +"\" is not a valid command.";
    alert(msg);
}

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
}

/** Main Program Functions */
function JsonObj(){
    var obj = [{
        "name": "Dire Wolf",
        "description": "A Dire Wolf emerges from the forest and bares it's fangs at you.",
        "health": 100,
        "attack": 25,
        "armor": 4
    },
        {
            "name": "Zombie",
            "description": "A Zombie groans from behind you. Protect your brain!",
            "health": 100,
            "attack": 5,
            "armor": 0,
            "specialAttackTurn": 2
        },
        {
            "name": "Dragon",
            "description": "A Dragon flies overhead. It roars a challenge and lands before you.",
            "health": 100,
            "attack": 10,
            "armor": 50
        }
    ];
    return obj;
}
function CreateHero(p){
    let name;
    do
    {
        if (p === null)
        {

            name = prompt("Enter a name for your Hero: ");
            if (typeof name === 'undefined' || name === null || name === "")
            {
                alert("Do not leave blank. ");
            }
        }
        else
        {
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

    } while (typeof name === 'undefined' || name === null || name === "");



    p = ChooseClass(p, name);


    return p;
}
function ChooseClass(p, name){
    do
    {
        let input = ClassMenu().toLowerCase();

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
}
function Fight(player, mList){
    let fightLoop = true;
    let dmg = -1;
    let turn = 1;
    do
    {
        let m = mList[0];
        // Declare monster to player
        if (turn === 1) {alert(m.description);}


        let menuLoop = true;
        do
        {
            menuLoop = false;
            console.log(player.name+"'s Health: "+player.health);

            // create player turn
            let input = FightMenu();
            switch (input)
            {
                case "a":
                case "attack":
                    dmg = player.attack - m.armor;
                    DamageCalc(dmg, m);
                    break;
                case "s":
                case "use skill":
                case "skill":
                    dmg = player.Skill() - m.armor;
                    DamageCalc(dmg, m);
                    break;
                case "r":
                case "run away":
                case "run":
                    alert("You successfully ran away. The "+m.name+" regains it's health while it waits for your return.");
                    m.health = 100;
                    player.health = 100;
                    fightLoop = false;
                    break;
                default:
                    menuLoop = true;
                    DefaultMenuMessage(input);
                    break;
            }

        } while (menuLoop);

        if (m.health < 1)
        {
            alert("You have slain the "+m.name+"!");
            mList.shift();
            turn = 1;
        }
        else
        {
            if (fightLoop)
            {
                // create monster turn
                MonsterAttack(player, m);
                if (player.health < 1)
                {
                    alert("You have died.");
                    fightLoop = false;
                    m.health = 100;
                    player.health = 100;

                }

                if (!player.canIBeAttacked)
                {
                    player.Status();
                }

            }
            turn = -1;
        }


    } while (fightLoop && mList.length > 0);

    if (mList.length < 1 && player.health > 0)
    {
        alert("Congratulations! You have slain all of the monsters.");

    }

    return mList;
}
function MonsterAttack(player, m){
    let dmg = m.attack - player.armor;

    if (player.canIBeAttacked)
    {
        if (player.classType === "Warrior")
        {
            if (dmg < 1)
            {
                alert("The "+m.name+" cannot damage you. Your armor is too strong.");
            }
        }
        else
        {
            dmg = m.attack - player.armor;
            alert("You take "+dmg+" damage from the "+m.name+".");
            player.health -= dmg;

        }
    }
    else
    {
        if (player.classType === "Archer")
        {
            alert("You dodge the "+m.name+"'s attack.");
        }

    }
}
function DamageCalc(dmg,m){
    if (dmg < 1)
    {
        alert("You do no damage. The "+m.name+"'s armor is too strong.");

    }
    else
    {
        alert("You do "+dmg+" damage to the "+m.name+".");

        m.health -= dmg;
    }
}

