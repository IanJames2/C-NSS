// Put your code here

const names = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];

for (const name of names) {
  console.log(name);
}

const ChosenFew = () => {
  const filteredNames = names.filter((theName) => theName.startsWith("The"));
  for (const filteredName of filteredNames) {
    console.log(filteredName);
  }
};

console.log(" ");
console.log("All Place Names");
ChosenFew();
