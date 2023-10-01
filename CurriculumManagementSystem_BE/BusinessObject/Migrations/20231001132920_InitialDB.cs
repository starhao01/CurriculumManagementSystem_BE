﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObject.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentType",
                columns: table => new
                {
                    assessment_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assessment_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentType", x => x.assessment_type_id);
                });

            migrationBuilder.CreateTable(
                name: "Batche",
                columns: table => new
                {
                    batch_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    batch_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batche", x => x.batch_id);
                });

            migrationBuilder.CreateTable(
                name: "ClassSessionType",
                columns: table => new
                {
                    class_session_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_session_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSessionType", x => x.class_session_type_id);
                });

            migrationBuilder.CreateTable(
                name: "LearningMethod",
                columns: table => new
                {
                    learning_method_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    learning_method_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    learning_method_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    learning_method_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningMethod", x => x.learning_method_id);
                });

            migrationBuilder.CreateTable(
                name: "LearningResource",
                columns: table => new
                {
                    learning_resource_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    learning_resource_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningResource", x => x.learning_resource_id);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    major_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    major_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    major_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    major_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.major_id);
                });

            migrationBuilder.CreateTable(
                name: "PreRequisiteType",
                columns: table => new
                {
                    pre_requisite_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pre_requisite_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRequisiteType", x => x.pre_requisite_type_id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    semester_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    semester_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semester_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    semester_end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    school_year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.semester_id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentMethod",
                columns: table => new
                {
                    assessment_method_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assessment_method_component = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assessment_type_id = table.Column<int>(type: "int", nullable: false),
                    AssessmentTypesassessment_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentMethod", x => x.assessment_method_id);
                    table.ForeignKey(
                        name: "FK_AssessmentMethod_AssessmentType_AssessmentTypesassessment_type_id",
                        column: x => x.AssessmentTypesassessment_type_id,
                        principalTable: "AssessmentType",
                        principalColumn: "assessment_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    specialization_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specialization_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialization_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    major_id = table.Column<int>(type: "int", nullable: false),
                    specialization_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Majorsmajor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.specialization_id);
                    table.ForeignKey(
                        name: "FK_Specialization_Major_Majorsmajor_id",
                        column: x => x.Majorsmajor_id,
                        principalTable: "Major",
                        principalColumn: "major_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreRequisite",
                columns: table => new
                {
                    pre_requisite_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pre_requisite_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pre_requisite_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRequisite", x => x.pre_requisite_id);
                    table.ForeignKey(
                        name: "FK_PreRequisite_PreRequisiteType_pre_requisite_type_id",
                        column: x => x.pre_requisite_type_id,
                        principalTable: "PreRequisiteType",
                        principalColumn: "pre_requisite_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    user_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    user_phone = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    user_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_User_Role_role_id",
                        column: x => x.role_id,
                        principalTable: "Role",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curriculum",
                columns: table => new
                {
                    curriculum_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    curriculum_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    english_curriculum_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curriculum_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialization_id = table.Column<int>(type: "int", nullable: false),
                    vocational_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vocational_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    english_vocational_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    batch_id = table.Column<int>(type: "int", nullable: false),
                    decision_No = table.Column<int>(type: "int", nullable: false),
                    approved_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    curriculum_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Batchsbatch_id = table.Column<int>(type: "int", nullable: false),
                    Specializationsspecialization_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculum", x => x.curriculum_id);
                    table.ForeignKey(
                        name: "FK_Curriculum_Batche_Batchsbatch_id",
                        column: x => x.Batchsbatch_id,
                        principalTable: "Batche",
                        principalColumn: "batch_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curriculum_Specialization_Specializationsspecialization_id",
                        column: x => x.Specializationsspecialization_id,
                        principalTable: "Specialization",
                        principalColumn: "specialization_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    subject_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    english_subject_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    learning_method_id = table.Column<int>(type: "int", nullable: false),
                    assessment_method_id = table.Column<int>(type: "int", nullable: false),
                    credit = table.Column<int>(type: "int", nullable: false),
                    option = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreRequisitepre_requisite_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.subject_id);
                    table.ForeignKey(
                        name: "FK_Subject_AssessmentMethod_assessment_method_id",
                        column: x => x.assessment_method_id,
                        principalTable: "AssessmentMethod",
                        principalColumn: "assessment_method_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_LearningMethod_learning_method_id",
                        column: x => x.learning_method_id,
                        principalTable: "LearningMethod",
                        principalColumn: "learning_method_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_PreRequisite_PreRequisitepre_requisite_id",
                        column: x => x.PreRequisitepre_requisite_id,
                        principalTable: "PreRequisite",
                        principalColumn: "pre_requisite_id");
                });

            migrationBuilder.CreateTable(
                name: "Combo",
                columns: table => new
                {
                    combo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    combo_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    combo_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    specialization_id = table.Column<int>(type: "int", nullable: false),
                    curriculum_id = table.Column<int>(type: "int", nullable: false),
                    combo_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combo", x => x.combo_id);
                    table.ForeignKey(
                        name: "FK_Combo_Curriculum_curriculum_id",
                        column: x => x.curriculum_id,
                        principalTable: "Curriculum",
                        principalColumn: "curriculum_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Combo_Specialization_specialization_id",
                        column: x => x.specialization_id,
                        principalTable: "Specialization",
                        principalColumn: "specialization_id");
                });

            migrationBuilder.CreateTable(
                name: "PLOs",
                columns: table => new
                {
                    PLO_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLO_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curriculum_id = table.Column<int>(type: "int", nullable: false),
                    PLO_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLOs", x => x.PLO_id);
                    table.ForeignKey(
                        name: "FK_PLOs_Curriculum_curriculum_id",
                        column: x => x.curriculum_id,
                        principalTable: "Curriculum",
                        principalColumn: "curriculum_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SemesterPlan",
                columns: table => new
                {
                    curriculum_id = table.Column<int>(type: "int", nullable: false),
                    semester_id = table.Column<int>(type: "int", nullable: false),
                    semester_plan_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semester_plan_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterPlan", x => new { x.semester_id, x.curriculum_id });
                    table.ForeignKey(
                        name: "FK_SemesterPlan_Curriculum_curriculum_id",
                        column: x => x.curriculum_id,
                        principalTable: "Curriculum",
                        principalColumn: "curriculum_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterPlan_Semester_semester_id",
                        column: x => x.semester_id,
                        principalTable: "Semester",
                        principalColumn: "semester_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumSubject",
                columns: table => new
                {
                    subject_id = table.Column<int>(type: "int", nullable: false),
                    curriculum_id = table.Column<int>(type: "int", nullable: false),
                    term_no = table.Column<int>(type: "int", nullable: false),
                    Curriculumscurriculum_id = table.Column<int>(type: "int", nullable: false),
                    Subjectssubject_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumSubject", x => new { x.curriculum_id, x.subject_id });
                    table.ForeignKey(
                        name: "FK_CurriculumSubject_Curriculum_Curriculumscurriculum_id",
                        column: x => x.Curriculumscurriculum_id,
                        principalTable: "Curriculum",
                        principalColumn: "curriculum_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumSubject_Subject_Subjectssubject_id",
                        column: x => x.Subjectssubject_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    quiz_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quiz_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.quiz_id);
                    table.ForeignKey(
                        name: "FK_Quiz_Subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecializationSubject",
                columns: table => new
                {
                    specialization_id = table.Column<int>(type: "int", nullable: false),
                    subject_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializationSubject", x => new { x.specialization_id, x.subject_id });
                    table.ForeignKey(
                        name: "FK_SpecializationSubject_Specialization_specialization_id",
                        column: x => x.specialization_id,
                        principalTable: "Specialization",
                        principalColumn: "specialization_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecializationSubject_Subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Syllabus",
                columns: table => new
                {
                    syllabus_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    decision_No = table.Column<int>(type: "int", nullable: false),
                    degree_level = table.Column<int>(type: "int", nullable: false),
                    syllabus_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject_id = table.Column<int>(type: "int", nullable: false),
                    student_task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    syllabus_tool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    syllabus_note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    min_GPA_to_pass = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    scoring_scale = table.Column<int>(type: "int", nullable: false),
                    approved_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    syllabus_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subjectssubject_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syllabus", x => x.syllabus_id);
                    table.ForeignKey(
                        name: "FK_Syllabus_Subject_Subjectssubject_id",
                        column: x => x.Subjectssubject_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboSubject",
                columns: table => new
                {
                    subject_id = table.Column<int>(type: "int", nullable: false),
                    combo_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboSubject", x => new { x.combo_id, x.subject_id });
                    table.ForeignKey(
                        name: "FK_ComboSubject_Combo_combo_id",
                        column: x => x.combo_id,
                        principalTable: "Combo",
                        principalColumn: "combo_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboSubject_Subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PLOMapping",
                columns: table => new
                {
                    PLO_id = table.Column<int>(type: "int", nullable: false),
                    subject_id = table.Column<int>(type: "int", nullable: false),
                    Subjectssubject_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLOMapping", x => new { x.PLO_id, x.subject_id });
                    table.ForeignKey(
                        name: "FK_PLOMapping_PLOs_PLO_id",
                        column: x => x.PLO_id,
                        principalTable: "PLOs",
                        principalColumn: "PLO_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PLOMapping_Subject_Subjectssubject_id",
                        column: x => x.Subjectssubject_id,
                        principalTable: "Subject",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    question_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    question_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quiz_id = table.Column<int>(type: "int", nullable: false),
                    answers_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answers_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answers_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answers_4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correct_answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.question_id);
                    table.ForeignKey(
                        name: "FK_Question_Quiz_quiz_id",
                        column: x => x.quiz_id,
                        principalTable: "Quiz",
                        principalColumn: "quiz_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLO",
                columns: table => new
                {
                    CLO_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLO_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    syllabus_id = table.Column<int>(type: "int", nullable: false),
                    CLO_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLO", x => x.CLO_id);
                    table.ForeignKey(
                        name: "FK_CLO_Syllabus_syllabus_id",
                        column: x => x.syllabus_id,
                        principalTable: "Syllabus",
                        principalColumn: "syllabus_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GradingStruture",
                columns: table => new
                {
                    grading_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grading_weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    grading_part = table.Column<int>(type: "int", nullable: false),
                    syllabus_id = table.Column<int>(type: "int", nullable: false),
                    minimum_value_to_meet_completion = table.Column<int>(type: "int", nullable: false),
                    grading_duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scope_knowledge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    how_granding_structure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assessment_method_id = table.Column<int>(type: "int", nullable: false),
                    grading_note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradingStruture", x => x.grading_id);
                    table.ForeignKey(
                        name: "FK_GradingStruture_AssessmentMethod_assessment_method_id",
                        column: x => x.assessment_method_id,
                        principalTable: "AssessmentMethod",
                        principalColumn: "assessment_method_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GradingStruture_Syllabus_syllabus_id",
                        column: x => x.syllabus_id,
                        principalTable: "Syllabus",
                        principalColumn: "syllabus_id");
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    material_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    material_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    material_purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    material_ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    material_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    syllabus_id = table.Column<int>(type: "int", nullable: false),
                    material_note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    learning_resource_id = table.Column<int>(type: "int", nullable: false),
                    material_author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    material_publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    material_published_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    material_edition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearningResourceslearning_resource_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.material_id);
                    table.ForeignKey(
                        name: "FK_Material_LearningResource_LearningResourceslearning_resource_id",
                        column: x => x.LearningResourceslearning_resource_id,
                        principalTable: "LearningResource",
                        principalColumn: "learning_resource_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_Syllabus_syllabus_id",
                        column: x => x.syllabus_id,
                        principalTable: "Syllabus",
                        principalColumn: "syllabus_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    schedule_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schedule_content = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    syllabus_id = table.Column<int>(type: "int", nullable: false),
                    ITU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schedule_student_task = table.Column<long>(type: "bigint", nullable: false),
                    student_material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lecturer_material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schedule_lecturer_task = table.Column<long>(type: "bigint", nullable: false),
                    student_material_link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lecturer_material_link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    class_session_type_id = table.Column<int>(type: "int", nullable: false),
                    remote_learning = table.Column<bool>(type: "bit", nullable: false),
                    ass_defense = table.Column<bool>(type: "bit", nullable: false),
                    eos_exam = table.Column<bool>(type: "bit", nullable: false),
                    video_learning = table.Column<bool>(type: "bit", nullable: false),
                    IVQ = table.Column<bool>(type: "bit", nullable: false),
                    online_lab = table.Column<bool>(type: "bit", nullable: false),
                    online_test = table.Column<bool>(type: "bit", nullable: false),
                    assigment = table.Column<bool>(type: "bit", nullable: false),
                    Syllabusssyllabus_id = table.Column<int>(type: "int", nullable: false),
                    SessionTypeclass_session_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.schedule_id);
                    table.ForeignKey(
                        name: "FK_Session_ClassSessionType_SessionTypeclass_session_type_id",
                        column: x => x.SessionTypeclass_session_type_id,
                        principalTable: "ClassSessionType",
                        principalColumn: "class_session_type_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_Syllabus_Syllabusssyllabus_id",
                        column: x => x.Syllabusssyllabus_id,
                        principalTable: "Syllabus",
                        principalColumn: "syllabus_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GradingCLO",
                columns: table => new
                {
                    grading_id = table.Column<int>(type: "int", nullable: false),
                    CLO_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradingCLO", x => new { x.grading_id, x.CLO_id });
                    table.ForeignKey(
                        name: "FK_GradingCLO_CLO_CLO_id",
                        column: x => x.CLO_id,
                        principalTable: "CLO",
                        principalColumn: "CLO_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GradingCLO_GradingStruture_grading_id",
                        column: x => x.grading_id,
                        principalTable: "GradingStruture",
                        principalColumn: "grading_id");
                });

            migrationBuilder.CreateTable(
                name: "TimeAllocation",
                columns: table => new
                {
                    CLO_id = table.Column<int>(type: "int", nullable: false),
                    session_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeAllocation", x => new { x.CLO_id, x.session_id });
                    table.ForeignKey(
                        name: "FK_TimeAllocation_CLO_CLO_id",
                        column: x => x.CLO_id,
                        principalTable: "CLO",
                        principalColumn: "CLO_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeAllocation_Session_session_id",
                        column: x => x.session_id,
                        principalTable: "Session",
                        principalColumn: "schedule_id");
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "role_id", "role_name" },
                values: new object[] { 1, "Dispatcher" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "role_id", "role_name" },
                values: new object[] { 2, "Manager" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "role_id", "role_name" },
                values: new object[] { 3, "Admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "user_id", "full_name", "role_id", "user_address", "user_email", "user_name", "user_phone", "user_status" },
                values: new object[] { 1, "Chu Quang Quan", 1, "Ha Nam", "chuquan2k1@gmail.com", "QuanCQ", 349457905, "Active" });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentMethod_AssessmentTypesassessment_type_id",
                table: "AssessmentMethod",
                column: "AssessmentTypesassessment_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_CLO_syllabus_id",
                table: "CLO",
                column: "syllabus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Combo_curriculum_id",
                table: "Combo",
                column: "curriculum_id");

            migrationBuilder.CreateIndex(
                name: "IX_Combo_specialization_id",
                table: "Combo",
                column: "specialization_id");

            migrationBuilder.CreateIndex(
                name: "IX_ComboSubject_subject_id",
                table: "ComboSubject",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculum_Batchsbatch_id",
                table: "Curriculum",
                column: "Batchsbatch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculum_Specializationsspecialization_id",
                table: "Curriculum",
                column: "Specializationsspecialization_id");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumSubject_Curriculumscurriculum_id",
                table: "CurriculumSubject",
                column: "Curriculumscurriculum_id");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumSubject_Subjectssubject_id",
                table: "CurriculumSubject",
                column: "Subjectssubject_id");

            migrationBuilder.CreateIndex(
                name: "IX_GradingCLO_CLO_id",
                table: "GradingCLO",
                column: "CLO_id");

            migrationBuilder.CreateIndex(
                name: "IX_GradingStruture_assessment_method_id",
                table: "GradingStruture",
                column: "assessment_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_GradingStruture_syllabus_id",
                table: "GradingStruture",
                column: "syllabus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Material_LearningResourceslearning_resource_id",
                table: "Material",
                column: "LearningResourceslearning_resource_id");

            migrationBuilder.CreateIndex(
                name: "IX_Material_syllabus_id",
                table: "Material",
                column: "syllabus_id");

            migrationBuilder.CreateIndex(
                name: "IX_PLOMapping_Subjectssubject_id",
                table: "PLOMapping",
                column: "Subjectssubject_id");

            migrationBuilder.CreateIndex(
                name: "IX_PLOs_curriculum_id",
                table: "PLOs",
                column: "curriculum_id");

            migrationBuilder.CreateIndex(
                name: "IX_PreRequisite_pre_requisite_type_id",
                table: "PreRequisite",
                column: "pre_requisite_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_quiz_id",
                table: "Question",
                column: "quiz_id");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_subject_id",
                table: "Quiz",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterPlan_curriculum_id",
                table: "SemesterPlan",
                column: "curriculum_id");

            migrationBuilder.CreateIndex(
                name: "IX_Session_SessionTypeclass_session_type_id",
                table: "Session",
                column: "SessionTypeclass_session_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Session_Syllabusssyllabus_id",
                table: "Session",
                column: "Syllabusssyllabus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Specialization_Majorsmajor_id",
                table: "Specialization",
                column: "Majorsmajor_id");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializationSubject_subject_id",
                table: "SpecializationSubject",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_assessment_method_id",
                table: "Subject",
                column: "assessment_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_learning_method_id",
                table: "Subject",
                column: "learning_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_PreRequisitepre_requisite_id",
                table: "Subject",
                column: "PreRequisitepre_requisite_id");

            migrationBuilder.CreateIndex(
                name: "IX_Syllabus_Subjectssubject_id",
                table: "Syllabus",
                column: "Subjectssubject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TimeAllocation_session_id",
                table: "TimeAllocation",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_role_id",
                table: "User",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComboSubject");

            migrationBuilder.DropTable(
                name: "CurriculumSubject");

            migrationBuilder.DropTable(
                name: "GradingCLO");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "PLOMapping");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "SemesterPlan");

            migrationBuilder.DropTable(
                name: "SpecializationSubject");

            migrationBuilder.DropTable(
                name: "TimeAllocation");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Combo");

            migrationBuilder.DropTable(
                name: "GradingStruture");

            migrationBuilder.DropTable(
                name: "LearningResource");

            migrationBuilder.DropTable(
                name: "PLOs");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "CLO");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Curriculum");

            migrationBuilder.DropTable(
                name: "ClassSessionType");

            migrationBuilder.DropTable(
                name: "Syllabus");

            migrationBuilder.DropTable(
                name: "Batche");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "AssessmentMethod");

            migrationBuilder.DropTable(
                name: "LearningMethod");

            migrationBuilder.DropTable(
                name: "PreRequisite");

            migrationBuilder.DropTable(
                name: "AssessmentType");

            migrationBuilder.DropTable(
                name: "PreRequisiteType");
        }
    }
}
