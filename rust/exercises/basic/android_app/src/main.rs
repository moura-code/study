use android_rs_glue::*;

#[no_mangle]
pub extern "C" fn android_main() -> i32 {
    let app = android_app!(()).init().unwrap();
    let window = app.window().unwrap();
    let surface = window.surface().unwrap();

    let mut display = surface.display().unwrap();

    let mut painter = display.paint();
    painter.set_color(Color::rgb(255, 0, 0));
    painter.draw_text("Hello, world!", 10, 10);

    surface.swap_buffers().unwrap();

    0
}