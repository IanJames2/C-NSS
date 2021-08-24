// Put your code here
console.log("Let's roll some dice, baby!");
console.log("---------------------------");

class Die {
  constructor(Die) {
    this.Value = value;
  }

  string() {
    let dieString = "Unknown";
    return dieString;
  }

  switchItUp = () => {
    let value = this.value;
    switch (value) {
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
  };


    const Roll = () => {
        const dieValue = () => {
            return Math.random(1, 6)
        } 
        const die = Object.create(Die(dieValue));
        return die
    };


    
}

for (let i = 0, i < 10, i++) {
    const die1 = Object.create(Die(Roll()));
    const die2 = Object.create(Die(Roll()));

    const message = `${die1} + ${die2} == ${die1.Value + die2.Value}`
    if (die1.Value == die2.Value) {
        message += "  DOUBLES!";
    }

    console.log(message);

    }