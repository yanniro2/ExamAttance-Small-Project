var subject_code = prompt("Enter the Subject Code:");
let number_session = prompt("Enter the number of Sessions:");
console.log(subject_code.toUpperCase());
console.log(number_session);
let attence = [];
let yes = 0;
let no = 0;
for (let i = 0; i < number_session; i++) {
  attence[i] = prompt("Attence " + i + " contiunes ? yes[y] : no [n] ");
}

for (let x = 0; x < attence.length; x++) {
  if (attence[x] === "yes") {
    yes = yes + 1;
  } else if (attence[x] === "no") {
    no = no + 1;
  } else {
    console.log("Error Datas");
  }
}

let per = 100 / ((yes + no) / yes);

console.log("Total attandance for the subject:" + yes);
console.log("Total Absent of the Subject:" + no);
console.log("Attendance persentage:" + per + "%");

if (per > 80) {
  console.log("The Candidate is Site for Exam");
} else {
  console.log("The Candidate is Not Site for Exam");
}
