// Put your code here
console.log("Let's roll some dice, baby!");
console.log("---------------------------");

class Die {
  constructor(value) {
    this.Value = value;
  }

  toString() {
    let dieString = "Unknown";

    switch (this.Value) {
      case 1:
        dieString = "one";
        break;
      case 2:
        dieString = "two";
        break;
      case 3:
        dieString = "three";
        break;
      case 4:
        dieString = "four";
        break;
      case 5:
        dieString = "five";
        break;
      case 6:
        dieString = "six";
        break;
      default:
        break;
    }

    return dieString;
  }
}

const Roll = () => {
  function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min) + min); //The maximum is exclusive and the minimum is inclusive
  }
  const die = new Die(getRandomInt(1, 7));
  return die;
};

for (let i = 0; i < 10; i++) {
  const die1 = Roll();
  const die2 = Roll();

  let message = `${die1} + ${die2} == ${die1.Value + die2.Value}`;
  if (die1.Value == die2.Value) {
    message += "  DOUBLES!";
  }

  console.log(message);
}
