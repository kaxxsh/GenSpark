class Person {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }

  greet = () => console.log(`Hello, my name is ${this.name}`);
}

class Student extends Person {
  constructor(name, age, studentId) {
    super(name, age);
    this.studentId = studentId;
  }

  study = () => console.log(`${this.name} is studying.`);
}

const student = new Student("kaxxsh", 22, "K12345");
student.greet();
student.study();
