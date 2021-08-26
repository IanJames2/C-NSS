// Put your code here
console.log("Do you believe in magic?");
console.log("------------------------");

let allSpells = [
  {
    Name: "Turn enemy into a newt",
    isEvil: true,
    EnergyReqired: 5.1,
  },
  {
    Name: "Conjure some gold for a local charity",
    isEvil: false,
    EnergyReqired: 2.99,
  },
  {
    Name: "Give a deaf person the ability to heal",
    isEvil: false,
    EnergyReqired: 12.2,
  },
  {
    Name: "Make yourself emperor of the universe",
    isEvil: true,
    EnergyReqired: 100.0,
  },
  {
    Name: "Convince your relatives your political views are correct",
    isEvil: false,
    EnergyReqired: 2921.5,
  },
];

const DisplaySpellBook = () => {
  allSpells.map((allspell) => {
    console.log(`{allSpell.Name}`);
  });
};

DisplaySpellBook();

// const SpellBook = () => {

//     {
//         Title: "pass",
//         let Spell = [

//         ]
//     }

// }

// const Spell = () => {
//     [
//         {
//         Name: "pass",
//         isEvil: false,
//         EnergyReqired: 4.1
//         }
//     ]
// }
