using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knowledge.Data.Migrations
{
    public partial class InitialEnglishDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnglishDictionaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    englishWord = table.Column<string>(nullable: true),
                    englishSentence = table.Column<string>(nullable: true),
                    englishSentence1 = table.Column<string>(nullable: true),
                    englishSentence2 = table.Column<string>(nullable: true),
                    polishWord = table.Column<string>(nullable: true),
                    polishSentence = table.Column<string>(nullable: true),
                    polishSentence1 = table.Column<string>(nullable: true),
                    polishSentence2 = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishDictionaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnglishWordsGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishWordsGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnglishWordsLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishWordsLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnglishDictionaryDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishDictionaryId = table.Column<int>(nullable: false),
                    EnglishWordsListId = table.Column<int>(nullable: true),
                    CorrectAnswersCount = table.Column<int>(nullable: true),
                    WrongAnswersCount = table.Column<int>(nullable: true),
                    EnglishWordsGroupId = table.Column<int>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CorrectWrittenCount = table.Column<int>(nullable: true),
                    WrongWrittenCount = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishDictionaryDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnglishDictionaryDetails_EnglishDictionaries_EnglishDictionaryId",
                        column: x => x.EnglishDictionaryId,
                        principalTable: "EnglishDictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnglishDictionaryDetails_EnglishWordsGroup_EnglishWordsGroupId",
                        column: x => x.EnglishWordsGroupId,
                        principalTable: "EnglishWordsGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnglishDictionaryDetails_EnglishWordsList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishDictionaryDetailsId = table.Column<int>(nullable: true),
                    EnglishWordsListsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishDictionaryDetails_EnglishWordsList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnglishDictionaryDetails_EnglishWordsList_EnglishDictionaryDetails_EnglishDictionaryDetailsId",
                        column: x => x.EnglishDictionaryDetailsId,
                        principalTable: "EnglishDictionaryDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnglishDictionaryDetails_EnglishWordsList_EnglishWordsLists_EnglishWordsListsId",
                        column: x => x.EnglishWordsListsId,
                        principalTable: "EnglishWordsLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnglishDictionaryDetails_EnglishDictionaryId",
                table: "EnglishDictionaryDetails",
                column: "EnglishDictionaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnglishDictionaryDetails_EnglishWordsGroupId",
                table: "EnglishDictionaryDetails",
                column: "EnglishWordsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishDictionaryDetails_EnglishWordsList_EnglishDictionaryDetailsId",
                table: "EnglishDictionaryDetails_EnglishWordsList",
                column: "EnglishDictionaryDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishDictionaryDetails_EnglishWordsList_EnglishWordsListsId",
                table: "EnglishDictionaryDetails_EnglishWordsList",
                column: "EnglishWordsListsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishDictionaryDetails_EnglishWordsList");

            migrationBuilder.DropTable(
                name: "EnglishDictionaryDetails");

            migrationBuilder.DropTable(
                name: "EnglishWordsLists");

            migrationBuilder.DropTable(
                name: "EnglishDictionaries");

            migrationBuilder.DropTable(
                name: "EnglishWordsGroup");
        }
    }
}
