// Put your code here
console.log("Do you believe in magic?");
console.log("------------------------");

const database = {
  allSpells: [
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
  ],
};

const getAllSpells = () => {
  return database.allSpells.map((allSpells) => ({ ...allSpells }));
};

const DisplaySpellBookGood = () => {
  console.log("Good Book");
  const spellsx3 = getAllSpells();
  spellsx3.map((allspell) => {
    if (allspell.isEvil === true) {
      console.log(` {allSpell.Name}`);
    }
  });
};

DisplaySpellBookGood();

const DisplaySpellBookBad = () => {
  console.log("   ");
  console.log("Bad Book");
  const spellsx2 = getAllSpells();
  spellsx2.map((allspell) => {
    if (allspell.isEvil === false) {
      console.log(` {allSpell.Name}`);
    }
  });
};

DisplaySpellBookBad();
