class Person {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }

  getDetails() {
    return `Name: ${this.name}, Age: ${this.age}`;
  }

  greet() {
    console.log(`Hello, my name is ${this.name}`);
  }
}

class Student extends Person {
  constructor(name, age, studentId, grades = []) {
    super(name, age);
    this.studentId = studentId;
    this._grades = grades;
  }

  addGrade(grade) {
    this._grades.push(grade);
  }

  getAverageGrade() {
    if (this._grades.length === 0) return 0;
    let total = this._grades.reduce((sum, grade) => sum + grade, 0);
    return total / this._grades.length;
  }

  getDetails() {
    return `${super.getDetails()}, Student ID: ${
      this.studentId
    }, Average Grade: ${this.getAverageGrade().toFixed(2)}`;
  }
}

class GraduateStudent extends Student {
  constructor(name, age, studentId, grades, thesisTitle) {
    super(name, age, studentId, grades);
    this.thesisTitle = thesisTitle;
  }

  getDetails() {
    return `${super.getDetails()}, Thesis Title: ${this.thesisTitle}`;
  }
}

// Example usage
const student = new Student("kaxxsh", 22, "k12345", [85, 90, 78]);
student.greet();
console.log(student.getDetails());

student.addGrade(95);
console.log(student.getAverageGrade());
console.log(student.getDetails());

const gradStudent = new GraduateStudent(
  "class",
  25,
  "c54321",
  [90, 92, 88],
  "cloud Computing"
);
gradStudent.greet();
console.log(gradStudent.getDetails());
