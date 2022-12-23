const prompt = require('prompt-sync')();

function greet(namePassedIn) {
  return 'Welcome to SALT, ' + namePassedIn;
}

// Main program
const name = prompt('What is your name? ');
const greeting = greet(name);
const greetingForEliza = greet("Eliza");
const greetingForObaid = greet("Obaid");
console.log(greeting);

module.exports.greet = greet;