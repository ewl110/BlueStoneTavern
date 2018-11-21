//* Gulp.js configuration
var
  //* modules
  gulp = require('gulp'),
  watch = require('gulp-watch'),
  //* CSS processing
  assets = require('postcss-assets'),
  autoprefixer = require('autoprefixer'),
  cssnano = require('cssnano'),
  //mqpacker = require('css-mqpacker'),
  postcss = require('gulp-postcss'),
  rename = require('gulp-rename'),
  sass = require('gulp-sass'),
  //* Image processing
  newer = require('gulp-newer'),
  imagemin = require('gulp-imagemin'),
  //* JavaScript processing
  concat = require('gulp-concat'),
  deporder = require('gulp-deporder'),
  stripdebug = require('gulp-strip-debug'),
  uglify = require('gulp-uglify'),

  //* development mode?
  devBuild = (process.env.NODE_ENV !== 'production'),

  //* folders
  folder = {
    src: 'source/',
    build: 'public/'
  }
;

var browserSync = require('browser-sync').create();

//* CSS processing
gulp.task('css', ['images'], function() {
  var postCssOpts = [
	  assets({ loadPaths: ['images/'] }),
	  autoprefixer({ browsers: ['last 2 versions', '> 2%'] }),
	  //mqpacker
  ];

  //if (!devBuild) {
    postCssOpts.push(cssnano);
  //}

  return gulp.src(folder.src + 'scss/main.scss')
    .pipe(sass({
      outputStyle: 'nested',
      imagePath: 'images/',
      precision: 3,
      errLogToConsole: true
    }))
    .pipe(rename('main.min.css'))
    //.pipe(postcss(postCssOpts))
    .pipe(gulp.dest(folder.build + 'css/'));
});

//* Image processing
gulp.task('images', function() {
  var out = folder.build + 'images/';
  return gulp.src(folder.src + 'images/**/*')
    .pipe(newer(out))
    .pipe(imagemin({ optimizationLevel: 5 }))
    .pipe(gulp.dest(out));
});

//* JavaScript processing
gulp.task('js', function() {
  var jsbuild = gulp.src(folder.src + 'js/**/*')
    .pipe(deporder())
    .pipe(concat('main.min.js'));

  //if (!devBuild) {
    jsbuild = jsbuild
      //.pipe(stripdebug())
      //.pipe(uglify());
  //}

  return jsbuild.pipe(gulp.dest(folder.build + 'js/'));
});

/* watch for changes when not using browser sync
gulp.task('watch', function() {
});
*/

//* Browser sync server setup
gulp.task('serve', function() {
  browserSync.init({
    proxy: "http://local.swingkat.com",
    host: "local.swingkat.com",
    open: 'external'
  });

	//* image changes
	gulp.watch(folder.src + 'images/**/*', ['images']).on('change', browserSync.reload);

	//* javascript changes
	gulp.watch(folder.src + 'js/**/*', ['js']).on('change', browserSync.reload);

	//* css changes
	gulp.watch(folder.src + 'scss/**/*', ['css']).on('change', browserSync.reload);
});

//* run all tasks
gulp.task('run', ['css', 'js']);

//* default task
gulp.task('default', ['run', 'serve']);