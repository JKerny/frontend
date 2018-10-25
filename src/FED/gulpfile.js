var gulp = require('gulp');
var sass = require('gulp-sass');
 
sass.compiler = require('node-sass');
 
gulp.task('build-sass', function () {
  return gulp.src('./Project/Assets/SCSS/*.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(gulp.dest('./Project/Assets/CSS'));
});
 
gulp.task('sass:watch', function () {
  gulp.watch('./Project/Assets/SCSS/*.scss', ['sass']);
});