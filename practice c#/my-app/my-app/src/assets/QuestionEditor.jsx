import { useEffect, useState } from "react";

function AssessmentListPage() {

    const [assessments, setAssessments] = useState([]);
    const [selectedAssessment, setSelectedAssessment] = useState(null);
    const [questions, setQuestions] = useState([]);

    useEffect(() => {fetchAssessments();}, []);

    // Fetch assessments
    async function fetchAssessments() {

        try {
            const response = await fetch("http://localhost:5000/api/assessments");
            const data = await response.json();
            setAssessments(data);
        } catch (error) {
            console.error("Error loading assessments", error);
        }
    }

    // Fetch questions
    async function fetchQuestions(assessmentId) {

        try {

            const response = await fetch( `http://localhost:5000/api/assessments/${assessmentId}/questions` );
            const data = await response.json();
            setQuestions(data);
            setSelectedAssessment(assessmentId);

        } catch (error) {
            console.error("Error loading questions", error);
        }
    }

    return (

        <div style={{ padding: "20px" }}>
            <h1>Technical Assessments</h1>

            {
                assessments.map((assessment) => (
                    <div key={assessment.assessmentId}
                        style={{border: "1px solid gray",marginBottom: "10px",padding: "10px" }} >

                        <h3>{assessment.title}</h3>
                        <p> Total Marks:{assessment.totalMarks}</p>
                        <button
                            onClick={() =>fetchQuestions(assessment.assessmentId ) } >
                            Open Assessment
                        </button>

                    </div>
                ))
            }

            {
                selectedAssessment && (
                    <QuestionList assessmentId={selectedAssessment}questions={questions}/>
                )
            }

        </div>
    );
}





function QuestionList({ assessmentId, questions }) {

    return (

        <div style={{ marginTop: "30px" }}>

            <h2>Questions</h2>

            {
                questions.map((question) => (

                    <QuestionEditor key={question.questionId}assessmentId={assessmentId} question={question}
                    />
                ))
            }

        </div>
    );
}





function QuestionEditor({ assessmentId, question }) {

    const [answerText, setAnswerText] = useState("");
    const [message, setMessage] = useState("");

    async function submitAnswer() {

        try {

            const response = await fetch("http://localhost:5000/api/submissions",
                {
                 method: "POST",
               headers: {"Content-Type": "application/json"},

                    body: JSON.stringify({assessmentId: assessmentId,questionId: question.questionId,studentId: 101,answerText: answerText })
                }
            );

            const data = await response.json();
            setMessage(data.message);
            setAnswerText("");

        } catch (error) {

            console.error("Submission error", error);
        }
    }

    return (

        <div
            style={{ border: "1px solid #ddd",padding: "15px",marginBottom: "20px" }}
        >

            <h3> {question.questionText} </h3>

            <p>Marks: {question.marks}</p>

            <textarea rows="8"
                cols="80"
                value={answerText}
                placeholder="Write your analytical answer here..."
                onChange={(e) => setAnswerText(e.target.value)}
            />

            <br /><br />

            <button onClick={submitAnswer}>  Submit Answer</button>

            {
                message && (<p style={{ color: "green" }}> {message}</p> )
            }

        </div>
    );
}




export default AssessmentListPage;