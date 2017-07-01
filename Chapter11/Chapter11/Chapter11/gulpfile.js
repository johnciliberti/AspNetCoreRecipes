/// <binding AfterBuild='copyToWwwRoot' />
var gulp = require('gulp');

var gulpCopy = require('gulp-copy');
var path_dest = 'wwwroot/lib';
var bower_components = 'bower_components';
gulp.task('copyToWwwRoot', function () {
    return gulp.src([
        bower_components + '/bootstrap/dist/**/*',
        bower_components + '/jquery/dist/*',
        bower_components + '/jquery-validation/dist/*',
        bower_components + '/jquery-validation-unobtrusive/*.js',
        bower_components + '/Respond/dest/*.js'
    ])
        .pipe(gulpCopy(path_dest, { prefix: 1 }));
});
