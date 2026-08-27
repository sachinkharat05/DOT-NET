const fs = require("fs");

exports.getAssessments = (req, res) => {

    const data =
        JSON.parse(
            fs.readFileSync("./data/assessments.json")
        );

    res.json(data);
};

exports.getQuestions = (req, res) => {

    const questions =
        JSON.parse(
            fs.readFileSync("./data/questions.json")
        );

    const assessmentId =
        parseInt(req.params.assessmentId);

    const filtered =
        questions.filter(
            q => q.assessmentId === assessmentId
        );

    res.json(filtered);
};

exports.submitAnswer = (req, res) => {

    const submissions =
        JSON.parse(fs.readFileSync("./data/submissions.json"));

    const newSubmission = {
        submissionId: submissions.length + 1,...req.body, submittedAt: new Date(), status: "SUBMITTED"
    };

    submissions.push(newSubmission);

    fs.writeFileSync(
        "./data/submissions.json",
        JSON.stringify(submissions, null, 2)
    );

    res.json({
        message: "Submission successful"
    });
};