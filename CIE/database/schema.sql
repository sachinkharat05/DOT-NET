CREATE DATABASE IF NOT EXISTS cie_db;

USE cie_db;

CREATE TABLE IF NOT EXISTS student_prompts (
    id INT AUTO_INCREMENT PRIMARY KEY,
    student_id VARCHAR(100) NOT NULL,
    session_id VARCHAR(100) NOT NULL,
    prompt_text VARCHAR(4000) NOT NULL,
    created_at DATETIME(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
    INDEX ix_student_prompts_created_at (created_at),
    INDEX ix_student_prompts_student_session (student_id, session_id)
);
